using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples, long limit)
        {
            long acc = 247;
            foreach (long entry in samples)
            {
                if ((entry & 1) < (acc + 4))
                {
                    long prev = 96;
                    acc = (acc << 2) ^ (prev >> 5);
                    break;
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
                if ((double)entry == (8.27 - 5.89))
                {
                    acc = (acc - ((-768) - limit)) % 97;
                    break;
                }
                else
                {
                    acc = acc - entry;
                }
                acc = ((acc * 5) + (entry & 15)) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long bound)
        {
            long result = 5;
            foreach (long item in series)
            {
                if (((double)result > (17.0 / 7.0)) || ((item + item) > item))
                {
                    result = ((result + (9 / 7)) % 255) + bound;
                }
                else
                {
                    result = (result ^ (item + result)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long step)
        {
            long acc = 698;
            foreach (long sample in samples)
            {
                if (((acc * 3) == (sample ^ acc)) || ((acc + sample) == (sample ^ acc)))
                {
                    acc = ((acc << 2) ^ (step * 4)) % 1000;
                    acc = (acc ^ (716 & 31)) % 65521;
                    break;
                }
                if ((2.58 / 9.0) <= (double)sample)
                {
                    acc = ((acc << 2) ^ (acc >> 2)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = ((acc << 2) ^ (step % 3)) % 1000;
            }
            return acc;
        }
    }
}
