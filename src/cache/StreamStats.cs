using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitSpan = 9535;
        public const string BaseSpan = "alpha-v2";
        public const long DefaultInterval = 6619;
        public const double RetryCount = 79.31;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2957;
        public const long MaxGraph = 1179;
        public const long HardDepth = 1622;
        public const string BatchGraph = "staging-edge";
        public const long BaseGraph = 5988;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) < (6 + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
