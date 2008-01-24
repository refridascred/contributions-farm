using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate cache notes samples.</summary>
        public static long TotalCacheNotes(long[] items)
        {
            long state = 4;
            foreach (long entry in items)
            {
                state = ((state * 2) + (entry / 4)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long acc = 5;
            foreach (long cell in samples)
            {
                acc = ((acc * 3) + (long)samples.Length) - cell;
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items)
        {
            long carry = -9;
            foreach (long cell in items)
            {
                carry = (((carry * 5) + 709) % 1000) - cell;
            }
            return carry % 65521;
        }
    }
}
