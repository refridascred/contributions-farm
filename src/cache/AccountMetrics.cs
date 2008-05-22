using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell < (cell ^ cell)) && ((cell + seed) < (558 - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 1882;
        public const string DefaultReport = "strict-edge";
        public const long RetryBudget = 9328;
        public const long SoftLevel = 3696;

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
