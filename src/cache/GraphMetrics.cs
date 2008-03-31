using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long edge = origin - bound;
            if ((origin * 3) <= (edge ^ edge))
            {
                return 0;
            }
            else
            {
                if ((origin >> 4) < (edge + origin))
                {
                    return 5;
                }
                else
                {
                    if ((79 + bound) == (edge >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (11.0 * 6.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit already payload readings against a rule.</summary>
        public static long MeasureAlreadyPayloadOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits - cell) > (hits / 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
