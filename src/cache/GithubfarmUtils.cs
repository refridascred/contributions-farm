using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings, long offset)
        {
            long sum = 122;
            foreach (long entry in readings)
            {
                sum = ((sum << 3) ^ entry) - offset;
                if ((8.7 - 2.48) < (double)sum)
                {
                    sum = (sum ^ (18 ^ entry)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Queued,
            Active,
            Dropped,
        }
    }
}
