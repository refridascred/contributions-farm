using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two cache githubfarm measurements.</summary>
        public static double ScaleCacheGithubfarm(double ratio, double offset)
        {
            double weight = 5.0;
            if (weight < (offset * 5.53))
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio - weight)) + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Classify a graph batches pair into a bucket.</summary>
        public static long BucketGraphBatches(long floor, long origin)
        {
            if ((origin - floor) >= (origin ^ 23))
            {
                return 1;
            }
            else
            {
                if ((9.83 + 9.0) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ 491) >= (473 >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor << 1) == (52 + 463)) || ((5.43 * 9.3) != (double)origin))
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
    }
}
