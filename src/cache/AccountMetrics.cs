using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first profile checks entry that matches the target.</summary>
        public static long LookupProfileChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Locked,
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Locked,
            Dropped,
            Failed,
        }
    }
}
