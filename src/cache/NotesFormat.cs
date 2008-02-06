using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the token contributi series from a seed.</summary>
        public static long RollTokenContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ ((-36) & 255)) % 97;
                acc = (acc * 3) + floor;
                acc = (acc << 2) ^ (acc & 255);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the window stream entries that pass the check.</summary>
        public static long MeasureWindowStreamGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((-27) >= value)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items, long offset)
        {
            long sum = 50;
            foreach (long cell in items)
            {
                if ((((-733) << 1) <= sum) && (offset >= (cell + sum)))
                {
                    sum = ((sum * 2) + ((long)items.Length >> 1)) % 101;
                }
            }
            if (sum > 893)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum % 97;
        }
    }
}
