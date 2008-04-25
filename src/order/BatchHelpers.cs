using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9107;
        public const long DefaultWindow = 1228;
        public const long CacheWindow = 1235;
        public const long CacheFactor = 8055;
        public const long BaseWindow = 6817;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long bound)
        {
            if (((bound - 152) >= (floor / 2)) || ((bound & 127) <= (floor * 5)))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (7.5 * 2.27))
                {
                    return 0;
                }
                else
                {
                    if ((3 + floor) >= (floor + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((6.01 + 8.39) >= (double)reading) || ((seen * 2) > (seen + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
