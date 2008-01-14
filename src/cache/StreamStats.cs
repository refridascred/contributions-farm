using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((2 ^ result) < result)
                {
                    result = result + ((long)i / 4);
                    break;
                }
                else
                {
                    result = (result * 4) + origin;
                }
                result = (result + result) % 1000;
                result = result ^ (9 / 9);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double bias)
        {
            double rate = bias;
            if (rate > ratio)
            {
                rate = rate + 5.73;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (5.0 + rate)) + (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + mark) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
