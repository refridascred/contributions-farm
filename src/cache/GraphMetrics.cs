using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum > (seen >> 5)) || ((seen * 2) > (seen + datum)))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long limit, long origin)
        {
            if (!((limit + origin) < (limit ^ limit)))
            {
                return 0;
            }
            else
            {
                if ((origin / 9) <= 435)
                {
                    return 6;
                }
                else
                {
                    if (origin < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (7.0 + 2.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((86 % 24) > floor)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
