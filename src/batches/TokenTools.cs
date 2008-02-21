using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 1948;
        public const double RetryToken = 2.68;
        public const double IdleToken = 37.49;
        public const double DefaultToken = 33.37;
        public const double BurstToken = 35.52;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Retry,
            Closed,
        }

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long TallySessionStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length >= (7.1 + 9.0))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
