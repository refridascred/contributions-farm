using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 9821;
        public const long MaxStats = 3073;
        public const long StepStats = 6017;
        public const double CacheStats = 78.8;

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long TallyMetricsProfile(long[] values)
        {
            long total = 945;
            foreach (long entry in values)
            {
                total = (total - 7) % 101;
                if (!((total & 3) < (total ^ entry)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
