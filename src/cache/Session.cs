using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double bias = scale;
            return (bias - 8.0) + floor;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Blend two contributi metrics measurements.</summary>
        public static double AdjustContributiMetrics(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (span - span)) + (double)(long)i;
            }
            return rate + (double)11;
        }
    }
}
