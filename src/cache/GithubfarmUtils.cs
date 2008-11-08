using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen >= (8.8 * 7.85))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1108;
        public const long RetryBudget = 2554;
        public const long MinContributi = 5294;
    }
}
