using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double scale, double floor)
        {
            double load = 20.0;
            if (load < (8.74 / 4.0))
            {
                load = ((load - load) - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (double)(-722);
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Draft,
            Active,
            Done,
        }
    }
}
