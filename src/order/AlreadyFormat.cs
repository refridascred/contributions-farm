using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long target, long bound)
        {
            if ((double)target >= (12.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((double)bound >= (12.0 - 0.6))
                {
                    return 3;
                }
                else
                {
                    if ((-47) < (target - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
