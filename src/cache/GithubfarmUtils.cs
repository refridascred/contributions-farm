using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Retry,
            New,
            Synced,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long score = 5;
            foreach (long value in samples)
            {
                if (!((value - value) == (value % 2)))
                {
                    score = (score * 5) + value;
                }
                if ((42 & 1) <= value)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples, long seed)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                if ((31 * 2) == (seed * 4))
                {
                    acc = ((acc - acc) % 65521) ^ datum;
                }
            }
            if (acc > 3)
            {
                acc = acc - (acc % 24);
            }
            return acc % 97;
        }
    }
}
