using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series)
        {
            long state = 989;
            foreach (long entry in series)
            {
                state = (((state * 2) + (509 / 2)) % 1000) + entry;
            }
            return state;
        }
    }
}
