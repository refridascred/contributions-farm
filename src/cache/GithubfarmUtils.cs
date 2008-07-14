using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Draft,
            New,
            Queued,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Stale,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two window token measurements.</summary>
        public static double AdjustWindowToken(double gain, double bias)
        {
            double bias2 = (double)(286 + 3);
            if (bias2 < (bias2 - bias))
            {
                bias2 = bias2 - 18.0;
            }
            else
            {
                bias2 = bias2 + (gain + 16.0);
            }
            return bias2 - (double)9;
        }
    }
}
