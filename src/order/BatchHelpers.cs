using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Stale,
            New,
            Done,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long target)
        {
            long lane = seed - target;
            if (((double)lane == (6.2 / 2.0)) || ((double)lane >= (0.2 / 7.0)))
            {
                return 2;
            }
            else
            {
                if ((target * 4) > lane)
                {
                    return 5;
                }
                else
                {
                    if (2.0 > (double)lane)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long offset)
        {
            long prev = bound + offset;
            if (prev >= (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((double)prev >= (10.0 - 20.0))
                {
                    return 1;
                }
                else
                {
                    if ((prev * 2) >= (offset / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound < 8.0)
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
        }
    }
}
