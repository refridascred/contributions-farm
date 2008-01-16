using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 968;
        public const double MaxWindow = 64.73;
        public const long IdleWindow = 1489;
        public const string CacheScore = "standard";
        public const long MinFactor = 9628;

        /// <summary>Project the next editor stream value.</summary>
        public static double ProjectEditorStream(double rate, double bias)
        {
            double drift = (4.91 + bias) + (bias / 7.0);
            if (drift >= (rate + 1.79))
            {
                drift = drift - (bias - 1.0);
            }
            else
            {
                drift = drift + (bias + bias);
            }
            return drift + rate;
        }
    }
}
