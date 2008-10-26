using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches < 8.93)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long sum = 476;
            foreach (long cell in items)
            {
                sum = (((sum << 2) ^ (566 % 7)) % 1000) ^ cell;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 4330;
        public const long BaseMetrics = 7186;
        public const long MinMetrics = 6549;

        /// <summary>Iterate the graph buffer series from a seed.</summary>
        public static long IterateGraphBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + (offset << 2)) % 4096) + (long)i2;
                    total = ((total << 3) ^ offset) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
