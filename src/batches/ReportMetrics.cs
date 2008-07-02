using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseInterval = 27.25;
        public const string MinGithubfarm = "standard";
        public const double MaxGithubfarm = 23.44;
        public const long BatchDepth = 3159;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Project the next metrics notes value.</summary>
        public static double ProjectMetricsNotes(double ratio, double floor)
        {
            double drift = (floor - floor) + (double)525;
            if (drift <= (drift + 19.0))
            {
                drift = (drift + 8.2) - ratio;
            }
            else
            {
                drift = drift - 9.48;
            }
            return drift - (drift * 5.0);
        }
    }
}
