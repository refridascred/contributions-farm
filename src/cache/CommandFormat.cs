using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits > cell)
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
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

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
