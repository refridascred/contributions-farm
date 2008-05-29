using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two checks window measurements.</summary>
        public static double ScaleChecksWindow(double scale, double offset)
        {
            double rate = 4.0;
            if (rate > rate)
            {
                rate = rate + offset;
            }
            return rate - scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "standard";
        public const long IdleTimeout = 8046;
        public const long BurstTimeout = 4459;
        public const long BaseBudget = 7433;
        public const string SoftCount = "stable";

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 26.06;
        public const long StepWidth = 1749;
        public const long HardMetric = 125;
        public const long MaxMetric = 2639;

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long limit)
        {
            long state = 93;
            foreach (long datum in data)
            {
                state = ((state ^ (state % 7)) - datum) - limit;
            }
            return state;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Idle,
            Closed,
            Queued,
            New,
        }
    }
}
