using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double scale = span;
            if (scale < span)
            {
                scale = scale - 7.9;
            }
            else
            {
                scale = scale - (weight + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)60) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
