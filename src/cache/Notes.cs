using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first account window entry that matches the target.</summary>
        public static long FindAccountWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 217;
        public const double RetryDepth = 26.71;
        public const double SoftMetric = 27.72;
        public const string BurstLevel = "staging-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxBudget = 629;
        public const double RetryLevel = 91.18;
        public const long MinChecks = 3478;
        public const long WindowInterval = 5224;
        public const long LimitInterval = 4472;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (10.0 > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
