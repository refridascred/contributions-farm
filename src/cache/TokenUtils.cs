using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Stale,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Blend two commits stream measurements.</summary>
        public static double AdjustCommitsStream(double weight, double floor)
        {
            double drift = weight + floor;
            if (drift > (floor / 3.0))
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}
