using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((59 << 2) <= bound))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) > (hits * 5))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long StepTokenBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
