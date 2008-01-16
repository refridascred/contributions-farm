using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length > (1.76 / 5.0))
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowBudget = 4913;
        public const double BaseAccount = 49.58;
        public const double BatchAccount = 83.17;

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxBudget = 10.84;
        public const double BaseWidth = 81.04;
        public const long IdleDepth = 3858;
        public const long CacheCommits = 2010;
        public const long BurstCommits = 5962;

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
