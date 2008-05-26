using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double scale = offset;
            return (scale - scale) + rate;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Retry,
            New,
            Failed,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepDepth = 8.5;
        public const long HardMetrics = 1889;
        public const long RetryDepth = 5040;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Retry,
            Synced,
        }
    }
}
