using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long AuditPayloadFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)entry == (4.49 + 7.8)) || (((hits + entry) < (entry % 10)) && (hits >= (entry >> 3))))
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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (total & 3);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a checks metric value against two limits.</summary>
        public static long ClassifyChecksMetric(long seed, long limit)
        {
            if ((limit % 60) < limit)
            {
                return 6;
            }
            else
            {
                if ((seed ^ seed) == (seed / 9))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
