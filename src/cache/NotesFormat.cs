using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up cache buffer samples.</summary>
        public static long MatchCacheBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if (4 <= (carry ^ (long)i))
                {
                    carry = ((carry * 4) + (carry & 15)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ ((long)i >> 5)) % 65521;
                }
                carry = (carry - (carry / 2)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((913 % 64) == (sample + sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
