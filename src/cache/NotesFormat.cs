using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long carry = 20;
            foreach (long reading in samples)
            {
                if (((4.75 - 2.11) == (double)carry) || ((8.82 - 6.4) != (double)carry))
                {
                    break;
                }
                carry = (carry << 2) ^ 26;
                if ((carry - carry) >= carry)
                {
                    carry = ((carry << 2) ^ (carry + 20)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ reading;
                }
            }
            if (carry < 61)
            {
                carry = (carry << 3) ^ 2;
            }
            return carry;
        }
    }
}
