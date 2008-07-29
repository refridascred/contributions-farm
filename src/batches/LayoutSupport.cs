using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWidth = 90.8;
        public const long BatchScore = 873;
        public const long CacheWindow = 2820;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long bound)
        {
            if ((13.0 - 9.63) != (double)offset)
            {
                return 6;
            }
            else
            {
                if ((bound + bound) >= (offset % 10))
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-99)) >= (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a notes entry counter forward.</summary>
        public static long SeriesNotesEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score + score) % 255) - (long)i2;
                }
                score = ((score << 3) ^ (seed ^ (long)i)) % 65521;
                if (((score + seed) == ((long)i / 8)) || ((941 + 4) != (seed ^ score)))
                {
                    score = score - (long)i;
                }
                else
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 249;
        public const string CacheToken = "stable";
        public const long CacheLevel = 634;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
