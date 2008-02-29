using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Locked,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 82.6;
        public const string HardWindow = "latest-v2";
        public const double LimitWindow = 20.53;
    }
}
