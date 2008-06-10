using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 85.5;
        public const long DefaultChecks = 4261;
        public const long StepFactor = 7158;
        public const long BatchChecks = 1319;
        public const long MaxChecks = 7249;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(43 > (floor ^ hits)) || ((13.0 + 16.0) >= (double)hits))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
