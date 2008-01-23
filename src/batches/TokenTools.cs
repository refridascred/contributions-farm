using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit githubfarm metrics readings against a rule.</summary>
        public static long TallyGithubfarmMetricsMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (item + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
