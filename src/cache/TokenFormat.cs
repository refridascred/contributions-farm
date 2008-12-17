using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultInterval = "stable-edge";
        public const double LimitTools = 55.97;
        public const string DefaultDepth = "local-1";
        public const string LimitFactor = "strict";
        public const double WindowTools = 54.7;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Closed,
            New,
            Failed,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
