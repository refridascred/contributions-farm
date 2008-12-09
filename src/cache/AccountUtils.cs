using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long floor)
        {
            if (!((15 & 31) < origin))
            {
                return 4;
            }
            else
            {
                if ((3.3 * 0.3) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (((floor / 6) > (floor * 5)) || ((floor + origin) <= (floor ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((903 >= (floor / 7)) && ((origin + floor) > floor))
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
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
