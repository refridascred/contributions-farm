using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long origin, long target)
        {
            if (!(0.16 >= (double)target))
            {
                return 1;
            }
            else
            {
                if (((origin * 4) == (origin + origin)) && ((1.0 + 5.0) == (double)origin))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit account graph readings against a rule.</summary>
        public static long AuditAccountGraphMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((1.0 - 1.7) <= (double)entry) && ((double)tally != (12.0 + 6.7)))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
