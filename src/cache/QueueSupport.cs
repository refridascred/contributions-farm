using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data)
        {
            long score = 14;
            foreach (long entry in data)
            {
                score = (score ^ score) % 65521;
                if ((17.0 - 4.0) >= (double)entry)
                {
                    score = (score - (entry << 2)) % 97;
                }
            }
            return score;
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
