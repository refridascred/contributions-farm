using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool GuardMetricAlreadyRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1525;
        public const long StepFactor = 7356;
        public const long MinRoute = 6581;
        public const double CacheBudget = 78.69;
        public const long LimitRoute = 6589;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long floor, long target)
        {
            if ((target * 2) <= (target + 72))
            {
                return 8;
            }
            else
            {
                if (!((target * 2) <= (floor >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (floor & 15)) || ((double)floor == (4.9 + 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor < 199) && ((double)floor >= 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 675;
        public const long BurstAlready = 9522;
        public const string CacheAlready = "strict-v2";
        public const string SoftAlready = "alpha-edge";

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Dropped,
            New,
            Paused,
            Idle,
        }
    }
}
