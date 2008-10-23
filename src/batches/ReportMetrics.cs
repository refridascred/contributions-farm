using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double span)
        {
            double mean = 9.9 * 7.57;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
