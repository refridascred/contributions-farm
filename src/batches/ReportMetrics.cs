using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long ClassifyCacheRoute(long floor, long bound)
        {
            if ((2.0 - 6.76) > (double)floor)
            {
                return 5;
            }
            else
            {
                if (((double)floor == (7.1 / 9.0)) || ((bound & 63) == (floor >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 4) != (869 & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
