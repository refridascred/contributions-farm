using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchSize = "standard-v2";
        public const long CacheDepth = 807;
        public const long HardDepth = 8527;
        public const long MinSpan = 7371;
        public const double CacheGithubfarm = 96.05;

        /// <summary>Check that every account commits entry stays within the limit.</summary>
        public static bool GuardAccountCommitsRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Synced,
            Retry,
            Closed,
        }
    }
}
