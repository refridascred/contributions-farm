using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token window figure with a bias.</summary>
        public static double SmoothTokenWindow(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 9.0)
            {
                drift = drift - rate;
            }
            return drift - rate;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double rate = (double)941 - 5.0;
            if (rate < rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (2.4 * 5.44)) + (double)(long)i;
            }
            return rate + (floor + ratio);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > 3.0)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }
    }
}
