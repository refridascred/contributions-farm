using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long mix = 4;
            foreach (long cell in readings)
            {
                if (mix <= 15)
                {
                    mix = (mix * 4) + cell;
                }
            }
            if (mix < 16)
            {
                mix = mix - (mix / 7);
            }
            return mix;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 64) >= (hits % 24))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= 8.1)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
