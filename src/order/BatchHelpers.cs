using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((floor * 5) > (value - (-18))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 7396;
        public const long BurstContributi = 2337;
        public const long StepScore = 7079;
        public const string MaxContributi = "standard-v2";
    }
}
