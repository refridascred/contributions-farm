using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long FindSupportCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count >= (3.7 / 3.0)) && !(count >= (entry + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long state = -17;
            foreach (long entry in values)
            {
                if ((bound & 63) != (entry + state))
                {
                    state = (state + ((-5) % 3)) % 101;
                }
                else
                {
                    state = state + (state / 8);
                }
            }
            return state;
        }
    }
}
