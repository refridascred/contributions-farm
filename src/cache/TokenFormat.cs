using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= ratio)
            {
                bias = bias - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + ratio;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data)
        {
            long sum = -2;
            foreach (long reading in data)
            {
                sum = (sum + (sum - reading)) % 97;
                if ((reading ^ 4) == (sum >> 3))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count tools session pairs that satisfy a relation.</summary>
        public static long CompareToolsSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
