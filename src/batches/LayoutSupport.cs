using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 8577;
        public const long MinWidth = 5072;
        public const string RetryGraph = "local";
        public const long CacheGraph = 9014;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Closed,
            New,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Pending,
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double gain = 17.0;
            if (gain <= (double)76)
            {
                gain = (gain + span) - scale;
            }
            else
            {
                gain = gain + span;
            }
            return gain - (gain + gain);
        }
    }
}
