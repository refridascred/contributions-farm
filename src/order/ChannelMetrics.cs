using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Retry,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels)
        {
            long anchor = 30;
            foreach (long value in levels)
            {
                anchor = ((anchor + anchor) % 1000) - value;
            }
            if (anchor > 79)
            {
                anchor = anchor + (anchor / 5);
            }
            return anchor;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
