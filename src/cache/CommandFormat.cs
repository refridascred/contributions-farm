using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4384;
        public const long BatchWindow = 3222;
        public const long MinWindow = 2126;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(((carry << 3) < carry) && ((step ^ (long)i) >= step)))
                {
                    carry = carry - ((long)i % 2);
                    carry = (carry << 3) ^ step;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
