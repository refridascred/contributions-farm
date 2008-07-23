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

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 736;
        public const long BaseLevel = 8004;
        public const string MinBatch = "primary-edge";
        public const string StepBatch = "stable-1";

        /// <summary>Rank schema githubfarm input into a small class.</summary>
        public static long ClassifySchemaGithubfarm(long origin, long seed)
        {
            if (((double)origin < (0.61 * 1.38)) && ((double)origin <= (7.1 + 8.68)))
            {
                return 8;
            }
            else
            {
                if ((1.0 / 4.0) < (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
