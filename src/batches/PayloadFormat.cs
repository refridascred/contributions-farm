using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                if ((double)value <= (6.3 * 4.6))
                {
                    anchor = ((anchor << 3) ^ (value + 92)) % 101;
                }
            }
            return anchor % 4096;
        }

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
