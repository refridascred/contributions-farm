using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double rate = (double)(820 / 9);
            if (rate < bias2)
            {
                rate = (rate + (bias2 * 0.59)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (bias2 + rate)) - (double)(long)i;
            }
            return rate + (double)1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9870;
        public const double StepDepth = 76.93;
        public const long DefaultScore = 2186;
    }
}
