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

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "legacy";
        public const long BaseCount = 4793;
        public const long MinBudget = 8436;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
