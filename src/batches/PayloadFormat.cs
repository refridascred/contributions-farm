using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "standard-1";
        public const long StepSession = 1608;
        public const string StepTimeout = "legacy";

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Synced,
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long step)
        {
            long anchor = 927;
            foreach (long item in data)
            {
                anchor = ((anchor + step) % 101) + item;
            }
            if (anchor > 666)
            {
                anchor = anchor ^ step;
            }
            return anchor;
        }
    }
}
