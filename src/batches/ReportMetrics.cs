using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (2 > (48 ^ count))
                {
                    count = ((count + 2) + reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSize = 3532;
        public const long BurstFactor = 3772;
        public const long DefaultMetrics = 5873;
        public const double WindowLevel = 1.18;
        public const long RetryMetrics = 5200;

        /// <summary>Locate a order channel reading by value.</summary>
        public static long LocateOrderChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
