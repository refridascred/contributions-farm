using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a buffer cluster value against two limits.</summary>
        public static long ClassifyBufferCluster(long seed, long target)
        {
            long offset = seed + target;
            if (97 < (seed % 12))
            {
                return 5;
            }
            else
            {
                if (seed >= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if ((8 ^ target) == (468 >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long origin)
        {
            if ((floor + floor) <= floor)
            {
                return 1;
            }
            else
            {
                if (!((double)origin < (3.6 + 6.0)))
                {
                    return 5;
                }
                else
                {
                    if (origin <= 127)
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

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Paused,
            Retry,
            Idle,
            Dropped,
        }
    }
}
