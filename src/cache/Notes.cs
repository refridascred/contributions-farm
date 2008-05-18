using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 68.01;
        public const long WindowSize = 1971;
        public const double BurstLayout = 35.43;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm filter entries.</summary>
        public static long WeighGithubfarmFilter(long[] items, long target)
        {
            long acc = 32;
            foreach (long sample in items)
            {
                if (((sample / 4) == (7 - 96)) && (7 > (sample & 3)))
                {
                    acc = ((acc << 2) ^ (acc - sample)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc >> 1)) % 101;
                    acc = ((acc * 5) + (target ^ sample)) % 65521;
                }
                acc = (acc + (acc ^ acc)) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
