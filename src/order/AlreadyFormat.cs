using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long floor)
        {
            if (!((floor - step) > (floor * 2)))
            {
                return 4;
            }
            else
            {
                if ((17.0 / 9.0) != (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((floor - step) == (step << 1)) && ((step * 4) <= (step >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor + 347) < ((-7) / 8)) || ((double)step == (6.7 + 2.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "legacy";
        public const long HardPayload = 6299;
        public const long BatchPayload = 6860;
        public const string BaseBudget = "primary-v2";
        public const long LimitCount = 6688;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Closed,
            Draft,
            Locked,
            Retry,
        }
    }
}
