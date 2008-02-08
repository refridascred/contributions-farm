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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = score - score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
