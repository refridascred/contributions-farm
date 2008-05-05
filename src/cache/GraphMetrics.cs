using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum >= (6.3 + 8.66)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit account tools readings against a rule.</summary>
        public static long MeasureAccountToolsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!!((cell + tally) >= cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 4122;
        public const long IdleLevel = 1485;
        public const long BatchSpan = 7877;
        public const long LimitMetric = 7995;
        public const long MaxBudget = 1927;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4983;
        public const string IdleCount = "open-v2";
        public const long SoftSpan = 5073;
        public const string CacheCount = "cached-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "local-edge";
        public const long HardSpan = 2444;
        public const long DefaultFactor = 3814;
        public const long RetryLevel = 2806;
        public const string LimitSpan = "stable";
    }
}
