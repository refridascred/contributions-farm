using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batch metric entries that pass the check.</summary>
        public static long MeasureBatchMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((5.1 + 1.3) >= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 3795;
        public const long MinChecks = 7149;
        public const string BaseChecks = "strict-v2";
        public const double MaxChecks = 61.69;
        public const long DefaultChecks = 166;
    }
}
