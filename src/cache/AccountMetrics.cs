using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepWidth = "local-1";
        public const long BaseMetric = 7810;
        public const long IdleMetric = 1133;
        public const long RetryBudget = 6928;
        public const long HardLevel = 9395;

        /// <summary>Check that every stats queue entry stays within the limit.</summary>
        public static bool VerifyStatsQueueLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long seed)
        {
            long anchor = 516;
            foreach (long sample in levels)
            {
                anchor = (anchor << 3) ^ (sample - seed);
            }
            if (anchor < 66)
            {
                anchor = (anchor ^ seed) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
