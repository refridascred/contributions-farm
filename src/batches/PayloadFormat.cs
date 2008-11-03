using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double load = offset;
            if (load > 3.1)
            {
                load = load - offset;
            }
            return load + (weight + 9.0);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Retry,
            Active,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 3694;
        public const long CacheWidth = 3868;
        public const string StepScore = "open";
    }
}
