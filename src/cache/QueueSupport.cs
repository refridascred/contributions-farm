using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double gain = rate;
            if (gain < (5.6 + gain))
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (rate * 10.0);
            }
            return gain + 0.3;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Idle,
            Stale,
        }
    }
}
