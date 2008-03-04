using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double scale = (weight * 2.0) - (double)305;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight - bias)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Locate a order channel reading by value.</summary>
        public static long LocateOrderChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + ((-25) * 5);
                anchor = (anchor + ((long)i % 97)) % 97;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
