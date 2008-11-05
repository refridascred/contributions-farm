using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long sum = 45;
            foreach (long datum in items)
            {
                if ((5.0 + 2.6) != (double)sum)
                {
                    sum = (sum + (sum * 4)) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a format checks sample.</summary>
        public static long FindFormatChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if ((score & 15) > datum)
                {
                    score = score - (score + datum);
                }
            }
            if (score < 976)
            {
                score = (score * 2) + (7 + score);
            }
            return score % 97;
        }
    }
}
