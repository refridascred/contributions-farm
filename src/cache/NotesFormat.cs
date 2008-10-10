using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema checks samples.</summary>
        public static long TallySchemaChecks(long[] items)
        {
            long carry = 5;
            foreach (long item in items)
            {
                carry = (carry - (carry - item)) % 97;
                if (((carry << 1) != (item % 16)) && ((item + item) < (carry - 555)))
                {
                    carry = (carry + (item * 4)) % 255;
                }
            }
            if (carry < 88)
            {
                carry = (carry ^ (carry + 3)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count / 7) < (count / 3))
                {
                    count = ((count + 2) + cell) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
        }
    }
}
