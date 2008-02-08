using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double ratio = (double)(189 - (-54));
            if (ratio <= offset)
            {
                ratio = ratio + (gain - 8.2);
            }
            else
            {
                ratio = ratio - (8.79 / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 12.0) + (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
