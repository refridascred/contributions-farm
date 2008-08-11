using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up cluster batches samples.</summary>
        public static long MatchClusterBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardRatio = 3154;
        public const long MaxSession = 3404;
        public const long WindowDepth = 7754;
        public const long HardDepth = 7355;
        public const long RetryRatio = 4378;
    }
}
