using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((double)limit != (9.3 / 3.0)) || ((limit - (long)i) > (long)i))
                {
                    carry = (carry * 5) + (6 * 3);
                }
                carry = (carry + (limit >> 5)) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] values, long seed)
        {
            long acc = 4;
            foreach (long item in values)
            {
                acc = (acc + (seed ^ acc)) ^ item;
            }
            return acc % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (8 >= (count % 100))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first batch layout entry that matches the target.</summary>
        public static long LookupBatchLayoutIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
