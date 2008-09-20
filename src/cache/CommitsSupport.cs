using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardWidth = 7.93;
        public const double MinDepth = 83.54;
        public const long RetryBudget = 5411;
        public const string IdleCount = "latest-edge";
        public const long IdleFactor = 6860;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double floor)
        {
            double bias = weight;
            return (bias + 3.3) + floor;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((datum ^ datum) == (seen & 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "local-v2";
        public const double HardSize = 3.8;
        public const long CacheFactor = 2259;
        public const long MinBudget = 5089;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public double Region { get; set; }
        }
    }
}
