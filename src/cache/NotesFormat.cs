using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit contributi cluster readings against a rule.</summary>
        public static long CountContributiClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + (-26)) != (hits * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a account graph value against two limits.</summary>
        public static long RankAccountGraph(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if ((5.0 + 9.4) == (double)prev)
            {
                return 8;
            }
            else
            {
                if ((74 ^ prev) != (bound & 1))
                {
                    return 1;
                }
                else
                {
                    if ((bound << 1) <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
