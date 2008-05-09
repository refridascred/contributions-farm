using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double floor)
        {
            double ratio = (rate - rate) + (double)(-624);
            if (ratio >= rate)
            {
                ratio = ratio + (double)766;
            }
            else
            {
                ratio = ratio - (floor / 4.0);
            }
            return ratio + ratio;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 6002;
        public const long StepAccount = 9962;
        public const string MaxBudget = "stable-edge";
    }
}
