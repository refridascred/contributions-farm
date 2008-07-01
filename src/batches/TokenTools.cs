using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long limit)
        {
            long offset = floor + limit;
            if (657 >= offset)
            {
                return 5;
            }
            else
            {
                if ((floor % 97) <= (offset / 5))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 1) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double bias, double span)
        {
            double weight = bias;
            if (weight > (bias + weight))
            {
                weight = weight + (bias / 2.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (span / 7.0)) - (double)(long)i;
            }
            return weight + (bias - 2.5);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 1804;
        public const string CacheLevel = "strict";
        public const long MinFactor = 4919;
        public const long BurstPayload = 2500;
    }
}
