using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi githubfarm readings.</summary>
        public static long TotalContributiGithubfarm(long[] series)
        {
            long sum = 900;
            foreach (long value in series)
            {
                sum = sum + (value + value);
            }
            return sum % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowDepth = 1960;
        public const string CacheRatio = "alpha";
        public const double BatchFactor = 59.79;
    }
}
