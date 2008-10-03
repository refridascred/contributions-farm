using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 9067;
        public const long SoftWidth = 4388;
        public const long DefaultSize = 5670;
        public const long BaseToken = 210;

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double weight = bias;
            if (weight > (ratio * 2.07))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)92) - (double)(long)i;
            }
            return weight - ratio;
        }
    }
}
