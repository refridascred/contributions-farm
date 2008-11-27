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

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Done,
            Synced,
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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstTimeout = 4865;
        public const long BurstFilter = 5080;
        public const long DefaultFilter = 9678;

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
