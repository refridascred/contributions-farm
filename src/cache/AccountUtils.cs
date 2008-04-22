using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count report session pairs that satisfy a relation.</summary>
        public static long MatchReportSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((sample + sample) > (sample * 4)) && ((double)sample <= (0.69 * 5.5))) || (((matches << 2) >= matches) || (matches < (sample * 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
