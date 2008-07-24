using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item >> 2) != (item << 3)))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 8441;
        public const string BaseRatio = "cached-1";
        public const long MaxWidth = 2482;
        public const long StepGithubfarm = 508;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleTimeout = 1861;
        public const double RetryFarm = 17.06;
        public const long SoftSpan = 3430;
        public const long BaseFarm = 5436;
        public const long BatchFarm = 4600;

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 49.45;
        public const long WindowBudget = 3350;
        public const double LimitDepth = 74.3;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
