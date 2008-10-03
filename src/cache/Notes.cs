using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Stale,
            New,
            Active,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (647 <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (3.97 - 3.22))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            long bound = limit + origin;
            if (((4 - origin) <= (limit ^ bound)) || ((6.51 + 1.63) <= (double)limit))
            {
                return 3;
            }
            else
            {
                if (((limit + origin) > (243 + limit)) && ((double)bound < (18.0 / 9.0)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit notes format readings against a rule.</summary>
        public static long CountNotesFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((49 / 9) <= (tally + tally)) || (((double)reading != (8.26 - 3.0)) && ((99 - tally) < ((long)series.Length * 5))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
