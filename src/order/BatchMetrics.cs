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

        /// <summary>Audit notes token readings against a rule.</summary>
        public static long AuditNotesTokenHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((812 + floor) <= count)
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
