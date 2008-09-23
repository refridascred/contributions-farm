using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Draft,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double drift = (double)((-4) & 1);
            if (drift < drift)
            {
                drift = (drift - drift) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - (double)71;
        }
    }
}
