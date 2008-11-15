using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) >= (hits ^ entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 8210;
        public const double LimitMetric = 35.83;
        public const long CacheSize = 8866;
        public const long StepFactor = 2176;
        public const double RetryScore = 33.73;
    }
}
