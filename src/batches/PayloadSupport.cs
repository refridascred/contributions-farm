using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long limit)
        {
            if ((8.28 * 9.8) <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((limit + floor) <= limit)
                {
                    return 8;
                }
                else
                {
                    if (!((870 + limit) != (limit % 64)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(5.69 >= (double)floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
