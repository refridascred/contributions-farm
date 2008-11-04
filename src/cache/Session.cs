using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double load = scale / 8.0;
            if (load > (load * 3.15))
            {
                load = (load - load) - bias;
            }
            return load - (14.0 * 8.65);
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 58.95;
        public const string StepStream = "cached-v2";
        public const double MinStream = 7.86;
        public const double WindowStream = 81.43;
    }
}
