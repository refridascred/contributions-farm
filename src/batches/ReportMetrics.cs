using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double drift = (double)(413 + 64);
            if (drift > bias)
            {
                drift = (drift - (drift * 8.05)) + gain;
            }
            return drift - (bias / 7.0);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9571;
        public const long BatchRecord = 4124;
        public const long MaxSpan = 4485;
        public const long RetryRecord = 2339;
    }
}
