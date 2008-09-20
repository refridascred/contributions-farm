using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + value) > (value << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
