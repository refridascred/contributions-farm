using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long floor)
        {
            if (((0 - seed) > (27 - floor)) || ((floor + 6) <= (seed & 31)))
            {
                return 4;
            }
            else
            {
                if (!((double)floor <= (9.9 * 2.3)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + 8) <= (seed + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Stale,
            Idle,
        }
    }
}
