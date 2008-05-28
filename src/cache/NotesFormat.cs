using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long origin)
        {
            if ((4.26 * 4.6) > (double)limit)
            {
                return 3;
            }
            else
            {
                if (!((3 & 63) < limit))
                {
                    return 2;
                }
                else
                {
                    if (!((limit % 8) > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Done,
            New,
            Idle,
            Paused,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                if (carry <= (cell % 5))
                {
                    carry = (carry - 0) % 1000;
                }
            }
            if (carry < 513)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry % 65521;
        }
    }
}
