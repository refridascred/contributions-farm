using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2289;
        public const long LimitEditor = 3474;
        public const long DefaultEditor = 516;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double bias)
        {
            double bias2 = (weight * 3.8) * 16.0;
            return (bias2 - weight) + bias;
        }
    }
}
