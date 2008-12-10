using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long sum = -33;
            foreach (long item in values)
            {
                if ((item + item) > (long)values.Length)
                {
                    sum = sum - (target ^ sum);
                }
                else
                {
                    sum = (sum - (2 - 2)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((5.0 + 3.25) == (double)value)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
