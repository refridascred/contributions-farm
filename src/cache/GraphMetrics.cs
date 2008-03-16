using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer account readings against a rule.</summary>
        public static long TallyBufferAccountGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((6 - hits) <= 0)
                {
                    hits = ((hits + 1) - item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 678;
        public const double MinRoute = 82.54;
        public const long DefaultRoute = 9350;
        public const double IdleSize = 45.34;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 6742;
        public const long DefaultLevel = 5355;
        public const string BatchLayout = "alpha-v2";

        /// <summary>Count report buffer pairs that satisfy a relation.</summary>
        public static long OverlapReportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstBudget = 41.29;
        public const long MinDepth = 3328;
        public const double MaxCount = 50.88;
        public const double BaseFormat = 88.07;
        public const string StepTimeout = "legacy-1";
    }
}
