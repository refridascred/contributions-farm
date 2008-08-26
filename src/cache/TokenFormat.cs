using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double gain = bias;
            if (gain < (bias + span))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain / 8.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowCount = 1596;
        public const double SoftSupport = 28.15;
        public const string DefaultBudget = "staging-edge";
        public const string WindowLevel = "cached-edge";
        public const string StepScore = "fallback";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] series, long seed)
        {
            long state = 391;
            foreach (long entry in series)
            {
                state = (((state * 3) + seed) % 1000) ^ entry;
            }
            return state;
        }
    }
}
