using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const string BatchCount = "open";
        public const double BurstReport = 32.35;
        public const double MaxReport = 64.28;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double gain, double span)
        {
            double rate = (double)(350 / 7);
            if (rate >= 17.0)
            {
                rate = (rate - (span + rate)) - gain;
            }
            else
            {
                rate = rate - (double)8;
            }
            return rate - (rate + 12.0);
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
