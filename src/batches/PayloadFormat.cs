using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((-710) & 63) > hits)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] levels)
        {
            long state = 8;
            foreach (long value in levels)
            {
                if ((double)state == (9.2 - 1.82))
                {
                    state = state + (value * 5);
                }
                else
                {
                    state = (state << 2) ^ (state + state);
                }
            }
            if (state > (-645))
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits == (double)56)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
