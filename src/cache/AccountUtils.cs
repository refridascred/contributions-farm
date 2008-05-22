using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of account contributi readings.</summary>
        public static long FoldAccountContributi(long[] items)
        {
            long anchor = 282;
            foreach (long reading in items)
            {
                if (92 > (reading & 255))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ (-187))) % 97;
                }
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
