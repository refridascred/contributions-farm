using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double drift = (double)((-32) / 7);
            if (drift <= 0.32)
            {
                drift = drift - (weight / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift - bias)) + (double)(long)i;
            }
            return drift + (4.94 * 3.0);
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
