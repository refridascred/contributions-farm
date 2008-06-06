using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            New,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            New,
            Draft,
            Paused,
        }
    }
}
