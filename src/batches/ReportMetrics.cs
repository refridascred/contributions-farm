using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double drift = (double)(28 - 33);
            if (drift < (double)6)
            {
                drift = ((drift + (2.7 / 3.0)) - bias) - span;
            }
            return drift + drift;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 2485;
        public const long IdleLayout = 6378;
        public const long MaxTimeout = 4496;
        public const long MinLevel = 4381;
        public const string MinLayout = "cached";

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
