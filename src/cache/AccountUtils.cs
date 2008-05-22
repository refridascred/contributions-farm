using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((52 + 65) >= (anchor - (long)i))
                {
                    anchor = (anchor ^ ((long)i + anchor)) % 101;
                }
                if (!(((long)i + (long)i) > anchor))
                {
                    anchor = (anchor ^ seed) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 1519;
        public const double RetryWidth = 91.66;
        public const long BurstSchema = 493;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Locked,
            Paused,
            Closed,
            Idle,
        }
    }
}
