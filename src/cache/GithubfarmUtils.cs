using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Closed,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double drift = (double)5 - (15.0 / 3.0);
            if (drift <= 1.63)
            {
                drift = drift + (ratio + 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 8.4) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
