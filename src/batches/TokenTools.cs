using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool GuardProfileCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                acc = (acc - (acc * 2)) ^ value;
                acc = (acc ^ limit) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 5192;
        public const long DefaultSpan = 8422;
        public const long IdleScore = 4384;
        public const double HardInterval = 5.31;
        public const double DefaultBudget = 3.06;
    }
}
