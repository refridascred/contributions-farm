using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double drift = bias + (span - 8.3);
            if (drift <= (drift + bias))
            {
                drift = drift + (span + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)11;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            New,
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
