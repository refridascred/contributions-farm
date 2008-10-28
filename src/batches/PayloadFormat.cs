using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstBudget = 7299;
        public const long RetryEditor = 3691;
        public const double MaxInterval = 78.45;
        public const string HardSize = "local-edge";

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Locked,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long state = 518;
            foreach (long cell in items)
            {
                state = ((((state << 2) ^ 42) % 4096) - cell) - limit;
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= (175 - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
