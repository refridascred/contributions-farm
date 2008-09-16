using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a graph format counter forward.</summary>
        public static long StepGraphFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double drift = (double)8 + (double)20;
            if (drift >= span)
            {
                drift = (drift - span) - scale;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 3.3) + (double)(long)i;
            }
            return drift - (drift - 1.62);
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
