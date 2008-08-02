using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6285;
        public const double BaseProfile = 5.87;
        public const string MaxCount = "open-1";
        public const string BurstInterval = "strict";
        public const string MaxProfile = "local-edge";

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            Pending,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.0 + 9.09) <= (double)entry)
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Ready,
            Idle,
            Retry,
            Closed,
        }
    }
}
