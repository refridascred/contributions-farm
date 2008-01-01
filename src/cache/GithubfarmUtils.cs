using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 85.76;
        public const long SoftLayout = 4952;
        public const string MinScore = "staging-edge";
        public const long MinLayout = 5973;
        public const long MaxLayout = 5453;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen - seen) > (seen << 3))
                {
                    seen = ((seen + 1) ^ value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            if (((limit % 60) <= (target + limit)) && ((target + limit) > (target % 64)))
            {
                return 6;
            }
            else
            {
                if ((0 >> 1) > (limit / 8))
                {
                    return 0;
                }
                else
                {
                    if ((0 / 3) <= ((-4) - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long seed)
        {
            if (((step * 2) < (seed + step)) || ((step + seed) == (step + step)))
            {
                return 8;
            }
            else
            {
                if ((seed > (step + seed)) && (seed >= (seed & 1)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
