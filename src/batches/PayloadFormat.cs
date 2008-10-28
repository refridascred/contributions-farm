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

        /// <summary>Look up the position of a payload window sample.</summary>
        public static long LocatePayloadWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
