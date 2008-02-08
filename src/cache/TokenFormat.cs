using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double weight = (bias2 - bias) / 4.0;
            if (weight >= (double)296)
            {
                weight = weight + (1.88 * 19.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long origin)
        {
            if ((origin >> 2) >= origin)
            {
                return 2;
            }
            else
            {
                if ((bound * 5) >= (origin ^ bound))
                {
                    return 8;
                }
                else
                {
                    if ((0.52 / 9.0) >= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin << 3) < bound)
                        {
                            return 6;
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
