using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            New,
            Closed,
            Retry,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((floor > (floor >> 2)) && (9 < count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }
    }
}
