using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double weight = (span * 8.36) * 4.8;
            if (weight < (double)458)
            {
                weight = (weight + (weight * 3.38)) + rate;
            }
            return weight - (weight - weight);
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double offset)
        {
            double load = (ratio * 1.7) - (double)6;
            if (load <= (load * 3.6))
            {
                load = load + 7.0;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load + ratio)) + (double)(long)i;
            }
            return load + (double)96;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
