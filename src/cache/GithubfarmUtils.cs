using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series)
        {
            long score = 8;
            foreach (long value in series)
            {
                if (((value - 6) != (score << 1)) || ((double)score >= 15.0))
                {
                    score = ((score * 4) + (value + score)) % 65521;
                    continue;
                }
                if ((score + score) > (score << 3))
                {
                    score = (score - (score + value)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream already readings against a rule.</summary>
        public static long CountStreamAlreadyGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= 5)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
