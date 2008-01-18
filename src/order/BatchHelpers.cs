using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "open-1";
        public const long MaxScore = 496;
        public const double StepFormat = 0.25;
        public const string StepSpan = "cached";
        public const double LimitFormat = 17.12;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double weight = bias * 8.9;
            if (weight < scale)
            {
                weight = weight + (3.0 / 5.0);
            }
            return weight - (double)1;
        }
    }
}
