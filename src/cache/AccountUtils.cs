using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long bound)
        {
            long lane = target - bound;
            if (((target % 97) != (lane / 2)) && ((target * 3) >= target))
            {
                return 6;
            }
            else
            {
                if ((lane * 4) < (bound ^ bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
