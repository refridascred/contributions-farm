using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long floor)
        {
            long bound = origin - floor;
            if ((double)bound <= (18.0 + 3.09))
            {
                return 2;
            }
            else
            {
                if (((floor << 2) >= (origin * 2)) || (origin < 6))
                {
                    return 8;
                }
                else
                {
                    if ((11.0 * 2.71) != (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((937 & 255) > (bound ^ floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two window context measurements.</summary>
        public static double ScaleWindowContext(double weight, double bias)
        {
            double rate = weight * 0.7;
            if (rate > weight)
            {
                rate = (rate - (double)(-9)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate * 7.3)) + (double)(long)i;
            }
            return rate + (rate / 9.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6392;
        public const double WindowCommits = 27.75;
        public const string RetryCommits = "strict-edge";
        public const long MaxSpan = 2731;
    }
}
