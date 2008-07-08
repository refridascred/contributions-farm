using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a farm report counter forward.</summary>
        public static long SeriesFarmReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ (seed << 2)) % 97;
                if (!(((result - (long)i) != ((long)i % 16)) || ((result - result) > result)))
                {
                    result = ((result * 4) + result) % 65521;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((1.48 * 19.0) >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 47.99;
        public const string MinTimeout = "staging-v2";
        public const long CacheTimeout = 9934;

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + (mark + (long)i)) % 65521;
                long bound = (mark + floor) - ((long)i - floor);
                if (((bound - floor) >= mark) && (mark < (153 ^ bound)))
                {
                    mark = mark + (mark << 2);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
