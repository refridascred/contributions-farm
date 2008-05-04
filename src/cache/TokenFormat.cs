using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two metrics account measurements.</summary>
        public static double ScaleMetricsAccount(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= (weight + 2.99))
            {
                weight = (weight + (double)29) - ratio;
            }
            else
            {
                weight = weight - (0.1 - weight);
            }
            return weight + (double)8;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of checks context readings.</summary>
        public static long OverlapChecksContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
