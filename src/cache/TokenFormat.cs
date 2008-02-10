using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double load = bias;
            if (load >= (double)4)
            {
                load = (load + load) + span;
            }
            else
            {
                load = load - 7.5;
            }
            return load + 3.67;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Ready,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
