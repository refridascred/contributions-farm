using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Dropped,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3 <= (hits << 3)) && !((double)target == (4.71 + 3.0)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the route schema series from a seed.</summary>
        public static long SeriesRouteSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = (total - ((long)i + target)) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((sample & 63) >= (tally % 97)) && (((tally >> 4) < (sample / 3)) || ((double)sample > 6.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
