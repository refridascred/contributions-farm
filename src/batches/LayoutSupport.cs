using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double mean = 9.0;
            return ((mean + mean) + bias) + bias2;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Locked,
            Paused,
            Synced,
            Pending,
        }
    }
}
