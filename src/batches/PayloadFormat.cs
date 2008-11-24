using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSize = 6200;
        public const long MinChannel = 1148;
        public const long RetryWidth = 5716;
        public const string RetryBudget = "fallback-edge";

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double mean = 1.84;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (offset * 3.62)) + (double)(long)i;
            }
            return mean - rate;
        }
    }
}
