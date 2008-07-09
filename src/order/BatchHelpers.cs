using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long bound)
        {
            long carry = -654;
            foreach (long item in items)
            {
                if ((item - bound) >= (bound / 8))
                {
                    carry = (carry ^ (bound * 2)) % 4096;
                }
            }
            if (carry < 6)
            {
                carry = (carry + (carry % 8)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
