using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - 42) > (limit ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next farm support value from a seed.</summary>
        public static long DeriveFarmSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((acc / 3) <= (acc & 1)))
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
