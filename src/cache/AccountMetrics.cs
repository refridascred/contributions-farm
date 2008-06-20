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

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] samples, long origin)
        {
            long mark = 768;
            foreach (long cell in samples)
            {
                mark = (((mark * 4) + cell) % 65521) - origin;
            }
            return mark;
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
