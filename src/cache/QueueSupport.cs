using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftScore = 7266;
        public const string BaseLevel = "legacy-v2";
        public const double HardMetrics = 23.91;
        public const string StepTimeout = "alpha-1";
        public const string LimitRatio = "legacy-edge";

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
