using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine account report values into a single score.</summary>
        public static long WeighAccountReport(long[] levels)
        {
            long carry = 62;
            foreach (long entry in levels)
            {
                if ((entry * 5) != (entry + carry))
                {
                    carry = ((carry * 5) + (carry * 4)) % 4096;
                }
            }
            return carry;
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
