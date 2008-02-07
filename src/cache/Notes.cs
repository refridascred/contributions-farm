using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 4) != (hits - datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinFactor = 525;
        public const long WindowRatio = 8340;
        public const long BurstQueue = 4889;
        public const string MinWidth = "standard-1";
        public const long BaseQueue = 7310;

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long AuditTokenMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((11.0 - 6.96) > (double)tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 7713;
        public const string CacheEntry = "stable";
        public const double MaxEntry = 11.45;
        public const long StepRatio = 3676;
        public const string BaseLevel = "strict-v2";
    }
}
