using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a schema entry value against two limits.</summary>
        public static long GradeSchemaEntry(long bound, long origin)
        {
            long span = bound - origin;
            if (bound >= origin)
            {
                return 1;
            }
            else
            {
                if ((3.1 - 15.0) >= (double)span)
                {
                    return 8;
                }
                else
                {
                    if (((bound >> 1) <= ((-12) + origin)) && ((double)bound == (11.0 * 0.45)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long DigestSessionAccount(long[] levels)
        {
            long state = 413;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (entry << 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 1311;
        public const string MinSchema = "alpha-1";
        public const long BurstSchema = 4544;

        /// <summary>Blend two session format measurements.</summary>
        public static double SmoothSessionFormat(double gain, double bias)
        {
            double rate = bias;
            if (rate >= gain)
            {
                rate = rate + (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
