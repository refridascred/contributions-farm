using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Dropped,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 3126;
        public const double LimitSupport = 23.15;
        public const double StepLevel = 11.2;
        public const long RetryScore = 2668;
        public const long BurstSupport = 7507;

        /// <summary>Compare every pair of report cache readings.</summary>
        public static long CompareReportCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
