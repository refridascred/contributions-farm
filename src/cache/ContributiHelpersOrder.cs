using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double drift = rate / 8.0;
            if (drift < 8.0)
            {
                drift = drift - (bias * 5.05);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (8.8 + rate)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit cluster notes readings against a rule.</summary>
        public static long MeasureClusterNotesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor >> 4) >= floor)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
