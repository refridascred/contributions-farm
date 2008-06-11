using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 66.7;
        public const long MaxReport = 7878;
        public const double StepFactor = 47.01;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheSize = 9796;
        public const long BurstLevel = 6116;
        public const long BurstChannel = 7072;
        public const string MinChannel = "alpha-v2";
        public const long StepChannel = 9232;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
