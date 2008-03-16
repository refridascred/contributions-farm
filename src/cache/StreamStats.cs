using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 96.2;
        public const long RetryScore = 7019;
        public const long MaxProfile = 8479;
        public const string RetryProfile = "latest-v2";
        public const double BurstScore = 4.59;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Validate editor profile readings against a bound.</summary>
        public static bool GuardEditorProfileRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
