using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two stream route measurements.</summary>
        public static double ScaleStreamRoute(double bias, double floor)
        {
            double gain = 19.0 + bias;
            if (gain >= (floor / 3.0))
            {
                gain = gain - (gain * 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (bias * 13.0)) + (double)(long)i;
            }
            return gain - (gain - gain);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 6571;
        public const double RetryReport = 16.49;
        public const long DefaultWidth = 3591;
        public const double BatchReport = 29.87;
        public const long LimitBudget = 2960;
    }
}
