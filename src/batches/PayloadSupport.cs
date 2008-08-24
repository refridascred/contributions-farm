using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 2396;
        public const string DefaultFactor = "latest-v2";
        public const long IdleSpan = 8702;
        public const long MinBudget = 9139;
        public const double StepDepth = 71.98;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double mean = span + (bias / 7.0);
            if (mean > mean)
            {
                mean = mean - (mean * 3.25);
            }
            return mean + (double)0;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Idle,
            Queued,
            Closed,
        }
    }
}
