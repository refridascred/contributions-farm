using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long seed)
        {
            long carry = 55;
            foreach (long cell in series)
            {
                if ((double)seed > 2.47)
                {
                    carry = (carry ^ (cell ^ seed)) % 97;
                }
                else
                {
                    carry = (carry + cell) % 1000;
                }
                if (!(seed >= carry))
                {
                    carry = (carry * 3) + (cell % 16);
                }
                if ((8.45 * 7.4) != (double)cell)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Match up graph cache samples.</summary>
        public static long PairGraphCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
