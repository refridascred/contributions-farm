using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count channel record pairs that satisfy a relation.</summary>
        public static long OverlapChannelRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a already stats pair into a bucket.</summary>
        public static long BucketAlreadyStats(long origin, long seed)
        {
            long edge = origin + seed;
            if (((0 + edge) < (edge ^ 973)) && ((double)origin > 20.0))
            {
                return 1;
            }
            else
            {
                if ((double)edge <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) != (origin / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits - cell) <= (-219)) || (((hits & 127) == (hits - cell)) && (hits <= (4 - cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
