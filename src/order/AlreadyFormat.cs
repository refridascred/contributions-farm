using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((limit + 6) < (limit % 12)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 7114;
        public const long WindowSpan = 1691;
        public const double IdleDepth = 7.44;
        public const long CacheInterval = 5045;
        public const string RetryQueue = "standard";

        /// <summary>Measure how many route window samples are out of range.</summary>
        public static long CountRouteWindowHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((-826) + seed) < (seed % 12))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (43 << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
