using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double ratio = (double)(835 % 7);
            if (ratio < (double)243)
            {
                ratio = (ratio + rate) + span;
            }
            return ratio + (double)8;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryInterval = 1350;
        public const double StepReport = 22.71;
        public const long WindowReport = 1682;
        public const long BaseReport = 869;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
