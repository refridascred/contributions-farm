using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics metric readings against a rule.</summary>
        public static long AuditMetricsMetricGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (origin > (602 << 1))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)1 <= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long limit)
        {
            long delta = bound - limit;
            if (((7.65 * 4.5) > (double)bound) && ((bound + delta) <= (delta << 3)))
            {
                return 6;
            }
            else
            {
                if ((limit / 3) < (delta + bound))
                {
                    return 2;
                }
                else
                {
                    if ((delta + (-876)) <= 4)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta >= (83 & 255)) || ((limit + bound) >= (bound * 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
