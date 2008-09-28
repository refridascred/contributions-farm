using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double AdjustLayoutPayload(double rate, double bias)
        {
            double gain = rate;
            if (gain < (rate + gain))
            {
                gain = gain - (bias + gain);
            }
            return gain - (bias * 11.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 9.1;
        public const long BatchLevel = 15;
        public const string RetryWidth = "alpha";
        public const double DefaultEditor = 75.78;
        public const string MinLevel = "cached-1";
    }
}
