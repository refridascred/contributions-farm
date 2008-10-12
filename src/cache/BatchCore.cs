using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double rate, double span)
        {
            double weight = span / 3.0;
            if (weight <= (weight - span))
            {
                weight = (weight + span) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + 4.28) + (double)(long)i;
            }
            return weight - (0.8 * 8.7);
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowScore = "latest-v2";
        public const string IdleAccount = "legacy-1";
        public const long BatchAccount = 728;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
