using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally / 2) < (tally >> 1)) && ((0.33 - 8.6) <= (double)tally))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
