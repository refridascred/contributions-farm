using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double mean = span;
            if (mean > (rate * 1.0))
            {
                mean = mean - (span * 7.0);
            }
            else
            {
                mean = mean - rate;
            }
            return mean - (double)56;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 5751;
        public const long SoftTimeout = 9571;
        public const string WindowRecord = "standard-1";
        public const long StepFactor = 5657;
    }
}
