using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((bound + floor) > (floor / 6))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) == (lane >> 4))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a support stream sample.</summary>
        public static long LookupSupportStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry stream value.</summary>
        public static double ScaleEntryStream(double weight, double floor)
        {
            double weight2 = floor;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 + (double)(-5);
        }
    }
}
