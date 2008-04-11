using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels)
        {
            long mark = -6;
            foreach (long entry in levels)
            {
                if (((0.3 / 2.0) < (double)entry) && ((double)entry >= (3.83 / 8.0)))
                {
                    mark = mark - (mark + entry);
                }
            }
            return mark % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseInterval = 9183;
        public const double RetryBudget = 60.93;
        public const long BatchPayload = 6212;
        public const long WindowPayload = 245;
        public const long LimitSpan = 6062;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long floor)
        {
            long acc = 109;
            foreach (long value in data)
            {
                acc = ((acc ^ (floor * 3)) % 65521) + value;
                acc = ((acc << 3) ^ (0 << 2)) % 4096;
            }
            if (acc > (-87))
            {
                acc = (acc * 5) + (647 + floor);
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
