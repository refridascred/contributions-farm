using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = (double)(243 >> 1);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (double)877) - (double)(long)i) - gain) + floor;
            }
            return mean + (double)0;
        }

        /// <summary>Project the next channel route value.</summary>
        public static double AdjustChannelRoute(double gain, double floor)
        {
            double drift = floor;
            if (drift >= 9.3)
            {
                drift = drift + (double)74;
            }
            return drift + gain;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
