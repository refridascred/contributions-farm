using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(tally <= (sample - sample)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryTimeout = 3628;
        public const long SoftBudget = 9499;
        public const long BaseRatio = 6452;
        public const double LimitCount = 39.68;
        public const long BaseFactor = 1790;
    }
}
