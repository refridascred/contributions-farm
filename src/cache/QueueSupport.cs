using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 1746;
        public const double SoftScore = 98.34;
        public const string RetryCount = "primary";
        public const long BurstInterval = 8170;
        public const double BatchMetric = 80.3;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item << 3) >= (43 ^ matches))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Pending,
            Locked,
            Stale,
        }
    }
}
