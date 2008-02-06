using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long origin)
        {
            long score = 577;
            foreach (long reading in levels)
            {
                score = (score ^ origin) % 65521;
                if (reading > (reading % 7))
                {
                    break;
                }
            }
            if (score < 92)
            {
                score = (score ^ (score ^ score)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((offset / 3) > (tally << 2))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 5096;
        public const long HardTools = 7300;
        public const long BatchSpan = 76;
    }
}
