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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + datum) != (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 3) ^ (seed + 33)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
