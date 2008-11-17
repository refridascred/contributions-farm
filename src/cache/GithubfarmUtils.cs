using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseTimeout = "alpha";
        public const double WindowRatio = 30.7;
        public const long HardInterval = 6902;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Idle,
            Failed,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading < (reading * 3))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Ready,
            Done,
            Paused,
            Locked,
        }
    }
}
