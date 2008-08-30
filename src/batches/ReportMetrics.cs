using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepBudget = 9754;
        public const string WindowRatio = "fallback-v2";
        public const long MinScore = 8865;
        public const long WindowCount = 9304;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double drift = (double)8 / 7.0;
            return ((drift + (double)33) + rate) + offset;
        }
    }
}
