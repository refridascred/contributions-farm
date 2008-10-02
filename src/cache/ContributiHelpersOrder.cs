using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double load = offset;
            if (load < bias)
            {
                load = load + (double)(-753);
            }
            return load + (offset + offset);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "open";
        public const double CacheSpan = 48.47;
        public const long StepStream = 224;
        public const long MinInterval = 171;
        public const string SoftStream = "legacy";
    }
}
