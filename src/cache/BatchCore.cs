using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a schema channel counter forward.</summary>
        public static long StepSchemaChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total + 344) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total << 3) ^ (total * 3)) % 97) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of layout batches readings.</summary>
        public static long TotalLayoutBatches(long[] levels, long origin)
        {
            long score = 4;
            foreach (long reading in levels)
            {
                if ((score * 4) != (reading - origin))
                {
                    score = ((score << 2) ^ reading) % 97;
                }
                else
                {
                    score = score - (long)levels.Length;
                }
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long score = 85;
            foreach (long sample in series)
            {
                score = ((score + bound) % 4096) + sample;
                if ((double)(long)series.Length >= (11.0 * 8.7))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
