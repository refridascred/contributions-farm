using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long acc = 840;
            foreach (long sample in samples)
            {
                if ((20.0 / 6.0) < (double)acc)
                {
                    acc = (acc + (sample + sample)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample / 9)) % 65521;
                }
            }
            if (acc > 4)
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long origin)
        {
            long total = 764;
            foreach (long datum in levels)
            {
                if ((0.19 + 0.25) < (double)total)
                {
                    total = (total - 950) + datum;
                }
                if (53 > origin)
                {
                    break;
                }
            }
            return total;
        }
    }
}
