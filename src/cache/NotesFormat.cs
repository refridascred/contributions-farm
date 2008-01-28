using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the channel editor series from a seed.</summary>
        public static long SeriesChannelEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed + seed) > seed)
                {
                    acc = (acc ^ (acc / 4)) % 97;
                }
                else
                {
                    acc = acc - acc;
                }
                if (!((seed + (long)i) < (acc & 1)))
                {
                    acc = ((acc * 3) + (seed / 3)) % 255;
                    acc = acc + acc;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5981;
        public const long MaxWidth = 1390;
        public const double BurstWindow = 8.12;
        public const long MaxWindow = 8587;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
