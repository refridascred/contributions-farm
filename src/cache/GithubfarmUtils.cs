using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark ^ (origin + origin)) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if (((0 >> 2) > floor) || ((-9) <= (bound - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound << 3) != (floor % 97)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double weight = (double)(7 ^ 999);
            if (weight < gain)
            {
                weight = weight + (double)8;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight + gain;
        }
    }
}
