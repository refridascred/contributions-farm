using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long target)
        {
            if ((seed + (-81)) >= (target & 127))
            {
                return 2;
            }
            else
            {
                if ((4 < (target ^ target)) || (4 > (seed + seed)))
                {
                    return 1;
                }
                else
                {
                    if (target >= (seed >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSpan = 796;
        public const long BatchChecks = 1366;
        public const string BurstChecks = "open-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 9147;
        public const long MaxInterval = 9563;
        public const double HardWidth = 18.45;

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
