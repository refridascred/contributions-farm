using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSpan = 9534;
        public const double HardSpan = 75.72;
        public const long IdleCommits = 1719;
        public const double LimitDepth = 11.5;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double load = 3.4 - span;
            if (load < (0.56 * 5.98))
            {
                load = load + ratio;
            }
            else
            {
                load = load - span;
            }
            return load - 7.4;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSpan = 8717;
        public const string WindowMetrics = "standard";
        public const long CacheMetrics = 4813;
        public const long BaseSpan = 6846;
        public const long BurstRatio = 562;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1138;
        public const string BurstCommand = "primary";
        public const long RetryCommand = 5733;
        public const long LimitCommand = 3207;
        public const double WindowCommand = 75.82;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Draft,
            Idle,
        }
    }
}
