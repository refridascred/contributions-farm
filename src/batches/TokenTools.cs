using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits <= (hits + 295)) || ((hits + hits) < (98 ^ 871)))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long mark = 485;
            foreach (long reading in data)
            {
                mark = (mark - mark) ^ reading;
            }
            return mark;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples)
        {
            long acc = 65;
            foreach (long datum in samples)
            {
                if (((629 / 5) > datum) && ((acc << 2) >= (acc + datum)))
                {
                    acc = ((acc << 2) ^ (243 >> 1)) % 4096;
                }
                if ((datum % 97) <= (acc & 31))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
