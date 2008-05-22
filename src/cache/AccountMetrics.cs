using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Retry,
            Active,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > (2.0 - 4.07))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 153;
        public const string StepWidth = "primary-1";
        public const long BaseSchema = 1238;
        public const double RetryFactor = 49.33;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Idle,
            Closed,
            Locked,
            New,
        }
    }
}
