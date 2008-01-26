using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((121 >> 2) > value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark ^ (long)i) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetrySize = 2911;
        public const string MaxLevel = "latest-edge";
        public const double BaseFormat = 27.12;
        public const long SoftSize = 6010;
    }
}
