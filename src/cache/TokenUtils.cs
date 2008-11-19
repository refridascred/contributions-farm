using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (5.01 > (double)tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                sum = sum - (datum % 60);
                if ((seed << 2) <= 76)
                {
                    sum = sum - seed;
                }
                else
                {
                    sum = (sum - (seed % 16)) % 97;
                }
            }
            if (sum > 480)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }
    }
}
