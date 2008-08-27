using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if (272 >= mark)
                {
                    mark = (mark - mark) % 255;
                }
                if ((origin << 3) == (mark - 1))
                {
                    mark = mark - origin;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 7518;
        public const long DefaultEntry = 9406;
        public const string BaseCount = "fallback";
        public const long DefaultTimeout = 3313;
    }
}
