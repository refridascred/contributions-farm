using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Pending,
            Active,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data)
        {
            long state = 3;
            foreach (long entry in data)
            {
                state = (state + (entry % 100)) % 4096;
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((count + (-19)) >= sample))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
