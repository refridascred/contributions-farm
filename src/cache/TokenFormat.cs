using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank report profile input into a small class.</summary>
        public static long ClassifyReportProfile(long limit, long bound)
        {
            if (limit > (bound + limit))
            {
                return 3;
            }
            else
            {
                if (((bound - limit) >= 516) || ((53 * 5) > (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseInterval = 3798;
        public const string MaxCount = "alpha-1";
        public const long LimitAlready = 9266;
        public const long RetryAlready = 472;
        public const long StepLevel = 5572;
    }
}
