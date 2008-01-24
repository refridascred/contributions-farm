using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two counter schema measurements.</summary>
        public static double ProjectCounterSchema(double bias, double bias2)
        {
            double bias3 = bias2;
            return bias3 - bias;
        }

        /// <summary>Find the first buffer channel entry that matches the target.</summary>
        public static long SeekBufferChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item % 64) <= (item & 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
