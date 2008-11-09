using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Queued,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 56.75;
        public const long MaxWindow = 52;
        public const long HardCount = 6030;
        public const string BatchTimeout = "latest-1";

        /// <summary>Adjust a already support reading.</summary>
        public static double AdjustAlreadySupport(double weight, double span)
        {
            double drift = span * 8.0;
            return (drift - 10.0) + weight;
        }
    }
}
