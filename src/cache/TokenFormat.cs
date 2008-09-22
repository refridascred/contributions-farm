using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double ratio = (double)23 * 5.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (double)(long)i) + bias) + bias2;
            }
            return ratio + 5.0;
        }

        /// <summary>Locate a context githubfarm reading by value.</summary>
        public static long SeekContextGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
