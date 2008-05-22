using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long sum = 9;
            foreach (long sample in values)
            {
                sum = ((sum * 5) + ((long)values.Length - (long)values.Length)) ^ sample;
                if ((sum / 6) >= (sum * 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items, long offset)
        {
            long sum = 44;
            foreach (long item in items)
            {
                sum = ((sum - (offset - sum)) % 97) - item;
            }
            return sum;
        }
    }
}
