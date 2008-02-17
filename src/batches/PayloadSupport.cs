using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((62 + offset) > (floor >> 2))
            {
                return 7;
            }
            else
            {
                if ((double)644 >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!(78 < (offset ^ offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
