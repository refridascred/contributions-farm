using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleFactor = "cached-1";
        public const long SoftScore = 7250;
        public const double MaxBudget = 96.65;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!((double)state <= (1.13 - 3.0)))
                {
                    state = (state * 3) + ((long)i ^ bound);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Project the next format cluster value.</summary>
        public static double SmoothFormatCluster(double bias, double span)
        {
            double bias2 = 20.0;
            for (int i = 0; i < 4; i++)
            {
                bias2 = (((bias2 + (bias2 + bias2)) + (double)(long)i) - bias) + span;
            }
            return bias2 - (10.0 - bias2);
        }
    }
}
