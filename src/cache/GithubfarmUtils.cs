using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count entry counter pairs that satisfy a relation.</summary>
        public static long PairEntryCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((19.0 - 2.9) < (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (2.3 <= (double)step)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long acc = 79;
            foreach (long sample in samples)
            {
                if (2 >= (acc - acc))
                {
                    acc = acc ^ (16 + sample);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 255;
                }
                if ((sample >> 2) > ((-79) - acc))
                {
                    break;
                }
            }
            if (acc > 443)
            {
                acc = (acc + (81 + acc)) % 65521;
            }
            return acc;
        }
    }
}
