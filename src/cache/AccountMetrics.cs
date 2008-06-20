using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 7193;
        public const double DefaultCount = 89.43;
        public const long MaxWidth = 6280;
        public const double BasePayload = 54.68;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            New,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (44 * 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
