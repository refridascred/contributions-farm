using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long anchor = -770;
            foreach (long cell in series)
            {
                if ((anchor >> 4) <= (4 / 7))
                {
                    anchor = (anchor ^ (cell ^ anchor)) % 255;
                }
            }
            return anchor;
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
