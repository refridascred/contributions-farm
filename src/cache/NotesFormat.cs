using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command format entries.</summary>
        public static long TotalCommandFormat(long[] data, long target)
        {
            long sum = 22;
            foreach (long item in data)
            {
                if (((double)sum > 0.29) && ((double)item < 19.0))
                {
                    sum = sum - item;
                }
                else
                {
                    sum = (sum ^ (target - item)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = (sum + (sum - target)) % 97;
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the tools batches entries that pass the check.</summary>
        public static long CountToolsBatchesMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item >> 4) <= (634 - (long)values.Length))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
