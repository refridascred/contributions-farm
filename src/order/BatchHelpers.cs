using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepInterval = 76.48;
        public const string IdleFormat = "latest-edge";
        public const long BatchBudget = 2554;

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 4583;
        public const long CacheCommand = 3684;
        public const string RetryDepth = "open";

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
