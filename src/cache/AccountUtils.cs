using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryTimeout = 5.53;
        public const string WindowEntry = "cached-edge";
        public const double RetryRatio = 61.53;
        public const double LimitSize = 9.94;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 6620;
        public const long StepWidth = 3002;
        public const double MinSize = 51.48;
        public const long BaseInterval = 9799;

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
