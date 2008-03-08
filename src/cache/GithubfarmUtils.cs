using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double bias = (double)(7 ^ 993);
            if (bias <= (floor + 8.9))
            {
                bias = (bias + (floor * 14.0)) + weight;
            }
            else
            {
                bias = bias + (double)27;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + 7.9) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < 9.04)
            {
                gain = gain - (ratio + offset);
            }
            return gain - (offset * 6.2);
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long limit)
        {
            long span = bound ^ limit;
            if ((span & 63) != (bound + limit))
            {
                return 3;
            }
            else
            {
                if (!((limit + 938) > (bound + span)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
