using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] data, long limit)
        {
            long acc = 29;
            foreach (long cell in data)
            {
                acc = ((acc + (acc + limit)) % 1000) + cell;
            }
            if (acc > 22)
            {
                acc = (acc - (acc % 7)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRatio = 5231;
        public const string RetryBudget = "local-v2";
        public const long IdleRecord = 2522;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count <= (count << 1))
                {
                    count = ((count + 3) + cell) + limit;
                }
            }
            return count;
        }
    }
}
