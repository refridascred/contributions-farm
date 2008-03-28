using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            New,
            Closed,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if (((bound >> 1) >= (bound2 & 15)) || ((-13) < (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((bound3 > (bound3 & 1)) || ((bound3 << 1) < (bound3 >> 1)))
                {
                    return 6;
                }
                else
                {
                    if (((bound2 << 1) == (bound3 + bound)) || ((bound * 2) >= (bound3 - bound2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((18.0 / 7.0) >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session cluster entry stays within the limit.</summary>
        public static bool GuardSessionClusterLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
