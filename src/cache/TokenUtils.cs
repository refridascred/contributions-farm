using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Ready,
            Done,
            Synced,
            Active,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
