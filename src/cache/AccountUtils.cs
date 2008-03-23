using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5638;
        public const long BurstScore = 8431;
        public const double BaseWidth = 58.07;
        public const long HardMetrics = 7148;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seed - sample) > (sample - seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
