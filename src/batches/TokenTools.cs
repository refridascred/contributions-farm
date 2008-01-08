using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Stale,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool ValidateMetricSessionBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4279;
        public const long LimitStream = 7292;
        public const double StepWidth = 65.9;
    }
}
