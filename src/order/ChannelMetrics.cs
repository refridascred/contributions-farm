using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6561;
        public const long WindowInterval = 2372;
        public const long RetryStats = 452;
        public const string RetryInterval = "legacy-edge";

        /// <summary>Measure how many farm report samples are out of range.</summary>
        public static long TallyFarmReportGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) >= (count % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
