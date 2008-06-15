using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a graph command counter forward.</summary>
        public static long DeriveGraphCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - sum) > (bound & 255))
                {
                    sum = sum - (bound << 2);
                }
                sum = sum - (bound / 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long step)
        {
            if ((4.11 / 6.0) >= (double)step)
            {
                return 8;
            }
            else
            {
                if (!((step - 54) > (816 ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((step - floor) < (floor % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + 573) >= (floor ^ step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
