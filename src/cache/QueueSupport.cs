using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((6.1 / 3.0) == (double)matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values, long origin)
        {
            long carry = 928;
            foreach (long value in values)
            {
                if ((value & 7) == (origin >> 5))
                {
                    carry = ((carry * 3) + ((-291) / 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long total = 510;
            foreach (long sample in samples)
            {
                total = (total - sample) % 65521;
                total = ((total << 2) ^ (585 / 2)) % 101;
                total = total + (total >> 5);
            }
            if (total > 9)
            {
                total = (total - (total & 31)) % 97;
            }
            return total;
        }
    }
}
