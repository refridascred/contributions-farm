using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long target)
        {
            long cur = offset + target;
            if (!((7.1 * 1.6) > (double)cur))
            {
                return 1;
            }
            else
            {
                if ((offset / 3) >= (171 - offset))
                {
                    return 8;
                }
                else
                {
                    if ((target - target) >= (cur + offset))
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

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 95;
        public const long HardSession = 2528;
        public const long BatchScore = 1314;
        public const string IdleSession = "stable-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "alpha-v2";
        public const string IdleGraph = "stable-v2";
        public const long LimitGraph = 9760;
    }
}
