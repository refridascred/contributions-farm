using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Idle,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Stale,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double weight, double floor)
        {
            double bias = (double)78;
            if (bias >= bias)
            {
                bias = (bias + floor) - weight;
            }
            return bias - floor;
        }
    }
}
