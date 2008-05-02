using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit tools order readings against a rule.</summary>
        public static long CountToolsOrderHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long mix = 866;
            foreach (long item in items)
            {
                if ((double)mix > (9.7 / 9.0))
                {
                    mix = (mix ^ (item / 8)) % 97;
                }
                else
                {
                    mix = ((mix * 2) + 257) % 101;
                }
            }
            if (mix < 3)
            {
                mix = (mix ^ (mix / 6)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many schema payload samples are out of range.</summary>
        public static long AuditSchemaPayloadHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (7.0 < (double)step)
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
