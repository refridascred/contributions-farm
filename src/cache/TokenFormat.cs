using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)bound >= (double)seen) && (((2.5 + 1.2) == (double)datum) && (bound < (240 & 7))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings, long floor)
        {
            long carry = 5;
            foreach (long value in readings)
            {
                if ((floor - value) >= (value ^ value))
                {
                    carry = (carry - (floor << 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
