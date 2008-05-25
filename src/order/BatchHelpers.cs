using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double rate, double bias)
        {
            double mean = bias / 3.0;
            if (mean <= (mean + rate))
            {
                mean = mean + (6.34 * 8.06);
            }
            else
            {
                mean = mean + rate;
            }
            return mean + (0.56 + bias);
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 2) ^ 430) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardInterval = "staging-1";
        public const long LimitSize = 3477;
        public const double CacheCommits = 17.52;
        public const string IdleCount = "staging";
    }
}
