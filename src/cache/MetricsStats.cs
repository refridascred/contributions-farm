using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum + matches) <= (342 ^ 199))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many support profile samples are out of range.</summary>
        public static long AuditSupportProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits - cell) != (hits % 100))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of session metrics readings.</summary>
        public static long MatchSessionMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 1758;
        public const long MaxScore = 49;
        public const long WindowToken = 7073;
        public const long DefaultToken = 3996;
        public const long MinToken = 1577;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const long DefaultNotes = 5900;
        public const long HardNotes = 8385;
        public const long MinInterval = 2861;
    }
}
