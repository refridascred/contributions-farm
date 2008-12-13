using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((bound - count) >= (cell % 2)) && ((cell % 16) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Active,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Idle,
            Dropped,
        }
    }
}
