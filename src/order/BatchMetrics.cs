using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitWidth = "cached-edge";
        public const long BatchCache = 9844;
        public const long BurstCache = 642;
        public const double BaseCache = 63.47;
        public const long IdleCache = 8290;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Paused,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((0.9 + 1.4) == (double)seen) && ((item >= (seen + seen)) && ((8.0 / 2.0) >= (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally <= (6.4 - 7.0))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading > (hits + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long FindCacheNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
