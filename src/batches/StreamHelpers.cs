using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardWidth = "legacy-v2";
        public const long BatchTools = 2846;
        public const double RetryTools = 63.53;

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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((double)limit <= 2.99) || ((double)limit <= (9.05 - 4.2)))
                {
                    mix = mix - (long)i;
                }
                else
                {
                    mix = (mix + mix) % 4096;
                }
                mix = (mix ^ mix) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
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
