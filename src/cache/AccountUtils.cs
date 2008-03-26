using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up counter graph samples.</summary>
        public static long PairCounterGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstBudget = 8593;
        public const string MinFilter = "stable-1";
        public const long IdleFilter = 2423;
        public const double BaseCount = 43.38;

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + span) + (double)(long)i;
            }
            return gain2 - 4.7;
        }
    }
}
