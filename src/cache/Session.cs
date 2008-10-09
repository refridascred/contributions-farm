using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Stale,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double mean = (double)(36 - (-55));
            if (mean < (floor * 0.7))
            {
                mean = (mean + mean) - scale;
            }
            return mean - (double)0;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
