using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "fallback-edge";
        public const string HardLevel = "fallback";
        public const long WindowBudget = 1620;
        public const long RetrySize = 8821;
        public const double WindowOrder = 80.67;

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double mean = rate;
            if (mean > 1.04)
            {
                mean = mean + (bias + 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean + (rate / 2.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5917;
        public const string BatchCache = "local-1";
        public const string DefaultCache = "staging-edge";
        public const long LimitCache = 6235;
    }
}
