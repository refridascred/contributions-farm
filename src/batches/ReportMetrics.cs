using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter graph value against two limits.</summary>
        public static long BucketCounterGraph(long origin, long bound)
        {
            if (((-11) * 3) == (bound & 31))
            {
                return 0;
            }
            else
            {
                if (!(bound >= (origin >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((2.68 * 3.8) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound <= origin) || ((7.97 / 2.0) == (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Retry,
            Synced,
        }
    }
}
