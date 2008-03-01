using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (234 > (matches ^ value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 1639;
        public const string RetryChecks = "standard";
        public const long BatchChecks = 3446;
        public const long StepInterval = 5337;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double bias, double span)
        {
            double scale = span;
            if (scale <= span)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (scale - scale);
        }
    }
}
