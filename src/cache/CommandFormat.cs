using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((0.6 / 5.0) == (double)count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((carry + (long)i) == (long)i)
                {
                    carry = (carry + carry) % 101;
                    carry = ((carry << 3) ^ (72 * 5)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
