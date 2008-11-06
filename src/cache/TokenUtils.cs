using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Queued,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double weight = 7.39;
            if (weight <= (ratio + floor))
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight - (double)61;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (double)66) + (double)(long)i;
            }
            return weight - (weight / 2.0);
        }
    }
}
