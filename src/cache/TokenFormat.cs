using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double bias = rate;
            if (bias > (double)34)
            {
                bias = bias - 7.86;
            }
            return bias + floor;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double rate = offset;
            if (rate <= rate)
            {
                rate = (rate - (rate * 5.2)) + weight;
            }
            else
            {
                rate = rate + 18.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)8) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
