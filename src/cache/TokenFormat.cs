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

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] values, long seed)
        {
            long mix = 75;
            foreach (long item in values)
            {
                if (((double)2 != (double)seed) && (((-534) + item) >= (seed - 155)))
                {
                    mix = (mix ^ (item * 3)) % 101;
                }
            }
            if (mix < (-4))
            {
                mix = ((mix << 3) ^ (mix * 2)) % 4096;
            }
            return mix;
        }
    }
}
