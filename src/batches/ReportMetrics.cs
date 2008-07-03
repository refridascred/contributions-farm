using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)hits > 7.99) || ((reading + hits) < (reading ^ 32)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long offset)
        {
            long bound2 = bound - offset;
            if ((bound + offset) > bound)
            {
                return 2;
            }
            else
            {
                if ((bound % 3) <= (bound2 / 7))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound2 <= (8.34 + 3.7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset != (3.5 * 3.7)) && ((offset - 34) != (bound ^ bound2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Paused,
            Draft,
            Active,
        }
    }
}
