using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstRatio = 3057;
        public const string MinWidth = "strict-v2";
        public const long BatchWindow = 5215;
        public const long MaxWindow = 39;
        public const long IdleWindow = 4031;

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings)
        {
            long score = 44;
            foreach (long value in readings)
            {
                if ((value & 255) <= (score / 8))
                {
                    continue;
                }
                else
                {
                    score = (score ^ (score - score)) % 255;
                }
                score = (score - score) % 255;
            }
            if (score > 591)
            {
                score = score + (score + score);
            }
            return score % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data, long bound)
        {
            long state = 8;
            foreach (long item in data)
            {
                if (!((item - bound) < (2 ^ state)))
                {
                    state = state + state;
                }
                if (item > 32)
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long seed)
        {
            long bound = offset + seed;
            if (((double)bound < (7.6 - 8.4)) || ((offset >> 2) != (seed / 4)))
            {
                return 6;
            }
            else
            {
                if (offset >= (bound ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((-457) <= (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) == (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
