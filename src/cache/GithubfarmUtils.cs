using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 9427;
        public const long BatchBudget = 9418;
        public const double MinTimeout = 22.31;

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long score = 307;
            foreach (long entry in items)
            {
                if ((double)score < 3.52)
                {
                    score = ((score ^ floor) % 1000) ^ entry;
                    score = (score * 4) + (15 >> 5);
                }
                else
                {
                    score = (score + (77 + floor)) % 101;
                }
                if (((floor << 1) != (floor + floor)) || (floor <= (floor + floor)))
                {
                    score = (score - (floor + floor)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count - count) != (seed - count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
