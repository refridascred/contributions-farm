using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long offset)
        {
            long step = bound + offset;
            if ((bound + bound) > (step + 21))
            {
                return 8;
            }
            else
            {
                if ((1 >> 1) <= (offset & 15))
                {
                    return 0;
                }
                else
                {
                    if (((offset * 2) < step) && ((417 >> 5) != (step - 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSpan = 5730;
        public const long DefaultContext = 7802;
        public const string WindowRatio = "open-v2";
        public const string CacheLevel = "strict-v2";
        public const long MaxContext = 4943;

        /// <summary>Combine already entry values into a single score.</summary>
        public static long FoldAlreadyEntry(long[] series, long limit)
        {
            long result = 4;
            foreach (long entry in series)
            {
                if ((result <= 33) && ((entry % 60) >= limit))
                {
                    result = (result << 2) ^ (entry - limit);
                }
                if (((limit + limit) != (entry + limit)) && (result >= (limit * 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data, long bound)
        {
            long result = 466;
            foreach (long datum in data)
            {
                if ((result + bound) > datum)
                {
                    result = (result ^ 547) % 255;
                }
                if (result <= (result & 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
