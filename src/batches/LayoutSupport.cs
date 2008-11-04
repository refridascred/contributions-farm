using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 2527;
        public const long StepBudget = 1298;
        public const long HardDepth = 5722;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool GuardTokenCacheBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
