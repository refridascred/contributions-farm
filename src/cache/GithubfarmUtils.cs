using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Limit { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Pending,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double ratio = 9.21;
            return ((ratio - 6.43) + bias) + offset;
        }
    }
}
