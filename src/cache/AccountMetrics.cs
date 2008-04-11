using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every payload profile entry stays within the limit.</summary>
        public static bool VerifyPayloadProfileLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long origin, long step)
        {
            if ((origin + 78) <= (origin & 31))
            {
                return 8;
            }
            else
            {
                if ((7.2 + 16.0) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 19.09;
        public const string IdleToken = "cached-edge";
        public const long CacheToken = 4350;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
