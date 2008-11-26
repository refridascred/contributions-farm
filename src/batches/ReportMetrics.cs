using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a buffer counter counter forward.</summary>
        public static long StepBufferCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a profile window reading.</summary>
        public static double SmoothProfileWindow(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 1.06) + (double)(long)i) + span;
            }
            return rate + 8.1;
        }
    }
}
