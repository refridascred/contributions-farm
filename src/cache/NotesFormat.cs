using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry entry stays within the limit.</summary>
        public static bool VerifyBatchEntryBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ offset;
                total = ((total << 3) ^ (offset / 5)) % 1000;
                if ((total + total) >= (total ^ 453))
                {
                    total = total + (total >> 1);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
