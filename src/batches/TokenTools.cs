using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            if ((floor + floor) != (bound % 10))
            {
                return 2;
            }
            else
            {
                if (((bound ^ 77) != (floor ^ floor)) || ((double)floor < (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (19 - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor < (floor % 16))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
