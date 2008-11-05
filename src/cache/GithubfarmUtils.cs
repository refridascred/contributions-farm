using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long target, long seed)
        {
            long next = target ^ seed;
            if (((seed * 3) > (9 + target)) && (4.91 < (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed - next) >= target)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
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
