using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Synced,
            Closed,
            Active,
            Stale,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double drift = rate;
            if (drift >= drift)
            {
                drift = drift + (floor / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift - 20.0)) + (double)(long)i;
            }
            return drift + (drift / 8.0);
        }
    }
}
