using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSize = 6518;
        public const double WindowSession = 83.7;
        public const long MaxInterval = 334;
        public const double MinWidth = 36.67;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowTimeout = 7437;
        public const double HardGithubfarm = 46.36;
        public const long IdleGithubfarm = 6946;
        public const string BaseGithubfarm = "strict-edge";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((9.0 / 8.0) <= (double)reading))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
