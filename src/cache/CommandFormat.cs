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

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data, long origin)
        {
            long mix = 63;
            foreach (long entry in data)
            {
                if ((double)origin != (9.67 + 9.7))
                {
                    mix = ((mix - (origin % 7)) % 4096) - entry;
                }
                if (!((8.0 + 1.16) >= (double)mix))
                {
                    break;
                }
            }
            if (mix > 75)
            {
                mix = mix + (-815);
            }
            return mix;
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
