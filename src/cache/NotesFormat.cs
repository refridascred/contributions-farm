using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ ((long)i + carry);
                carry = ((carry * 3) + (limit << 1)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels)
        {
            long sum = 90;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) >= (sum + 545)) || ((entry + sum) != (sum + entry)))
                {
                    sum = (sum ^ (0 - 90)) % 1000;
                }
            }
            return sum % 97;
        }
    }
}
