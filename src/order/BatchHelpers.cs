using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items, long step)
        {
            long carry = 688;
            foreach (long item in items)
            {
                if (!((carry * 4) < (carry / 3)))
                {
                    carry = ((carry + (carry + item)) % 4096) - step;
                }
            }
            if (carry < 79)
            {
                carry = (carry - (carry + carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long acc = 17;
            foreach (long item in levels)
            {
                if ((double)acc != (16.0 + 5.0))
                {
                    acc = ((acc ^ (7 + (-458))) % 101) - item;
                }
            }
            return acc;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            New,
            Draft,
        }
    }
}
