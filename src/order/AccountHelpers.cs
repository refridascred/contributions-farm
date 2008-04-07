using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Audit checks filter readings against a rule.</summary>
        public static long CountChecksFilterGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - hits) < (hits % 5))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 5.28;
        public const double BaseSupport = 62.69;
        public const long HardSupport = 1986;
        public const double StepRatio = 14.81;

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "open";
        public const long WindowTimeout = 2280;
        public const string CacheReport = "fallback-edge";
    }
}
