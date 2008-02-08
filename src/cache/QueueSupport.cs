using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (2 + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels)
        {
            long carry = 409;
            foreach (long datum in levels)
            {
                carry = ((carry * 5) + (datum - datum)) % 1000;
                if ((datum - 3) != (carry - carry))
                {
                    carry = carry + (datum << 2);
                }
            }
            if (carry > 3)
            {
                carry = ((carry << 2) ^ (82 >> 1)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long AuditPayloadEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (8 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
