using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of channel tools readings.</summary>
        public static long OverlapChannelToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 3865;
        public const string BaseWidth = "alpha-1";
        public const string HardSpan = "open-v2";
        public const double MinWidth = 86.26;
        public const long HardMetrics = 305;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 2) < (101 << 3))
                {
                    hits = ((hits + 2) + entry) + bound;
                }
            }
            return hits;
        }
    }
}
