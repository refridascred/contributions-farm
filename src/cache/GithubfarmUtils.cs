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

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long target)
        {
            if (!((double)offset >= (5.63 + 17.0)))
            {
                return 8;
            }
            else
            {
                if ((offset < (offset ^ target)) || (1 > (offset >> 3)))
                {
                    return 2;
                }
                else
                {
                    if (((offset + target) <= (target & 127)) && ((offset + target) != (offset + 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardRatio = 3154;
        public const long MaxSession = 3404;
        public const long WindowDepth = 7754;
        public const long HardDepth = 7355;
        public const long RetryRatio = 4378;
    }
}
