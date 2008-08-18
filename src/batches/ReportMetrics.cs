using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "cached-v2";
        public const long RetryWidth = 9654;
        public const double CacheAlready = 24.66;
        public const string MinAlready = "local-edge";

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 6;
            }
            else
            {
                if (origin < offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
