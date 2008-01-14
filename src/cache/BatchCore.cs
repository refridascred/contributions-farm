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

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftBudget = "primary-v2";
        public const long CacheSpan = 2244;
        public const double CacheStats = 52.87;
        public const long MinRatio = 8341;
        public const long BatchStats = 9228;

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
