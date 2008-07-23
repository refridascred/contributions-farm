using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double scale, double span)
        {
            double scale2 = 4.3 - (scale * 8.55);
            return (scale2 + 7.5) + span;
        }

        /// <summary>Combine checks batch values into a single score.</summary>
        public static long ScoreChecksBatch(long[] values, long target)
        {
            long anchor = 81;
            foreach (long reading in values)
            {
                if ((double)anchor <= (4.0 / 4.0))
                {
                    anchor = (((anchor << 3) ^ ((long)values.Length / 8)) % 97) + target;
                    break;
                }
                anchor = (anchor + (reading << 1)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstBudget = "cached-edge";
        public const long LimitCount = 9198;
        public const long StepBudget = 3386;
    }
}
