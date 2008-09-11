using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheTimeout = 6197;
        public const long RetryInterval = 6743;
        public const string CacheRoute = "alpha";
        public const long RetryBudget = 1756;
        public const long DefaultRoute = 7205;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= 5.0))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
