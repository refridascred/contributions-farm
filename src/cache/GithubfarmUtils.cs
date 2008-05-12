using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample >= (matches + 340))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long step)
        {
            long bound = target ^ step;
            if ((bound << 3) >= step)
            {
                return 6;
            }
            else
            {
                if ((target + bound) > (step ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (!((10 << 1) > step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 3411;
        public const long BatchMetrics = 2785;
        public const long SoftMetrics = 558;
        public const double WindowTimeout = 40.66;
        public const string MinMetrics = "alpha-v2";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + (mix * 5);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
