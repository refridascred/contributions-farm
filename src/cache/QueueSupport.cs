using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count order payload pairs that satisfy a relation.</summary>
        public static long PairOrderPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] values)
        {
            long result = 4;
            foreach (long item in values)
            {
                if ((item * 4) <= (89 + 71))
                {
                    result = result - (long)values.Length;
                }
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen << 2) != (seen >> 1)) && (seen < (origin + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
