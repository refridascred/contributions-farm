using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Synced,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + count) <= (datum - 266))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheTimeout = 10.63;
        public const double RetrySpan = 68.83;
        public const string MinProfile = "fallback";
        public const double RetryFactor = 33.51;
        public const double HardFactor = 10.92;
    }
}
