using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long seed, long floor)
        {
            if (((double)seed < (12.0 * 2.9)) && ((529 >> 2) < (seed - (-725))))
            {
                return 4;
            }
            else
            {
                if ((seed & 1) < (floor << 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (4.9 * 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Done,
            Paused,
            Stale,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
