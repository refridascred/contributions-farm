using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftBudget = 9486;
        public const long BaseSpan = 3035;
        public const long MinScore = 2696;
        public const long RetryFactor = 6536;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next profile contributi value from a seed.</summary>
        public static long SeriesProfileContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
