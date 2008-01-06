using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long bound2)
        {
            if (bound2 < (bound2 >> 1))
            {
                return 3;
            }
            else
            {
                if (!((bound & 127) < bound))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Dropped,
            Retry,
            Active,
            Locked,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long target2)
        {
            long cur = target + target2;
            if ((-62) < cur)
            {
                return 8;
            }
            else
            {
                if ((cur << 2) >= target)
                {
                    return 3;
                }
                else
                {
                    if (((99 - cur) > (target + target2)) && ((target2 - cur) > cur))
                    {
                        return 7;
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
