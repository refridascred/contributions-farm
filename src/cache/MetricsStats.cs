using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double drift = floor;
            if (drift >= (5.6 * 19.0))
            {
                drift = drift + bias;
            }
            return drift + (drift + drift);
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool ValidateSchemaMetricLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Locked,
            Paused,
            New,
            Retry,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double gain = (floor + bias) / 5.0;
            if (gain < (gain - gain))
            {
                gain = gain + (double)797;
            }
            return gain - (double)52;
        }
    }
}
