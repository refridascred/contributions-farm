using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
