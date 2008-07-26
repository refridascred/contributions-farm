using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((step + entry) != (entry >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 5715;
        public const long MaxSupport = 4868;
        public const long DefaultSupport = 7181;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long offset, long offset2)
        {
            if (!((double)offset2 > 4.0))
            {
                return 2;
            }
            else
            {
                if ((3 ^ offset2) < offset2)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
