using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long ScoreCounterGithubfarm(long[] series, long offset)
        {
            long mix = -1;
            foreach (long entry in series)
            {
                if ((double)offset > (19.0 / 3.0))
                {
                    mix = (mix ^ (mix + entry)) % 97;
                    break;
                }
                mix = mix + offset;
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] levels, long floor)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if (((double)floor != (17.0 * 9.8)) || ((item * 2) <= 2))
                {
                    acc = ((acc * 5) + (9 >> 4)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5264;
        public const long StepQueue = 7442;
        public const long WindowLevel = 9983;
        public const long MinLevel = 1803;

        /// <summary>Fold a list of stream filter readings.</summary>
        public static long DigestStreamFilter(long[] series, long step)
        {
            long acc = 49;
            foreach (long value in series)
            {
                acc = ((acc - (acc % 5)) + value) - step;
            }
            return acc % 1000;
        }
    }
}
