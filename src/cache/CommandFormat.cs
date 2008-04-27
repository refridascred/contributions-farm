using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit stats farm readings against a rule.</summary>
        public static long CountStatsFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) >= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Retry,
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Draft,
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
