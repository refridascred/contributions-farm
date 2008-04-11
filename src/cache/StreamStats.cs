using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record entry reading by value.</summary>
        public static long FindRecordEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 56.95;
        public const long BaseRecord = 1963;
        public const long BurstRecord = 3488;
        public const string IdleRecord = "fallback-1";
        public const long HardCount = 6842;
    }
}
