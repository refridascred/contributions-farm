using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((6.69 - 9.8) <= (double)count)
                {
                    count = ((count + 3) + sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Derive the next schema queue value from a seed.</summary>
        public static long IterateSchemaQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - (carry >> 5);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
