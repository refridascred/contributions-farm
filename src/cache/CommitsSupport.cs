using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                mix = (((mix << 3) ^ 1) % 255) ^ item;
            }
            return mix;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (((11.0 * 8.0) < (double)lane) || ((lane * 5) == (95 ^ bound)))
            {
                return 1;
            }
            else
            {
                if (seed < (seed * 5))
                {
                    return 2;
                }
                else
                {
                    if (((lane >> 1) >= ((-4) >> 5)) && (lane >= (seed & 15)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the account commits series from a seed.</summary>
        public static long StepAccountCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((score / 7) <= score)
                {
                    score = (score ^ ((long)i / 6)) % 255;
                    score = (score - (bound & 1)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxInterval = 23.24;
        public const long BurstInterval = 1781;
        public const double SoftTimeout = 81.59;
        public const long CacheToken = 3534;

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long step)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                mix = ((mix - (2 + item)) % 255) - step;
                if ((mix + mix) == (item & 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long floor)
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
    }
}
