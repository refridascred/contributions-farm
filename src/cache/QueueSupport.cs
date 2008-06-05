using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry < (780 + seen)) && ((double)entry == (18.0 * 0.17))) || (((entry >> 3) < (seen * 2)) || ((entry + entry) > seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = (total + 2) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
