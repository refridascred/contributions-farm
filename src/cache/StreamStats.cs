using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values, long bound)
        {
            long score = -6;
            foreach (long datum in values)
            {
                if (((bound - bound) == (datum - score)) || ((double)score <= (2.79 * 7.2)))
                {
                    score = (score + (402 + (-7))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ 9) >= (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            New,
            Pending,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits - hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
