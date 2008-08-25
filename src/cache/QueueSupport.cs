using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed & 3) != (seed & 31))
                {
                    acc = acc - ((long)i + seed);
                }
                else
                {
                    acc = (acc ^ (seed & 63)) % 97;
                }
                acc = (acc - ((long)i - acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((2.22 / 4.0) < (double)cell)
                {
                    hits = (hits + 1) - origin;
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
