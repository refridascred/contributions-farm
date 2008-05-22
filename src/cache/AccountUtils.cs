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

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheLevel = 28.05;
        public const string StepScore = "open";
        public const string HardInterval = "local-edge";
        public const long MaxSpan = 777;
        public const long MinCount = 9519;
    }
}
