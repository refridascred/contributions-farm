using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((double)origin <= (0.16 + 0.8))
                {
                    anchor = ((anchor * 2) + (origin << 3)) % 97;
                    anchor = (anchor - (anchor % 16)) % 101;
                }
                anchor = ((anchor * 5) + ((long)i & 1)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry + (953 + carry)) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
