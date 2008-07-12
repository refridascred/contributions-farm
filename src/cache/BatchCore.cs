using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a graph context pair into a bucket.</summary>
        public static long BucketGraphContext(long seed, long limit)
        {
            if ((limit ^ seed) < (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((18.0 - 3.24) != (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (!((seed + seed) >= 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit * 3) != (seed + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long floor2)
        {
            if ((floor ^ floor2) < floor)
            {
                return 3;
            }
            else
            {
                if (((0.3 + 7.1) >= (double)floor) && ((9.43 * 1.0) < (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (floor2 < 17)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Closed,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Queued,
            Done,
            New,
        }
    }
}
