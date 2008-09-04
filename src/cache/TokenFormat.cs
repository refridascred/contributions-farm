using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "staging-v2";
        public const double BatchWidth = 12.27;
        public const long LimitSize = 7570;
        public const long CacheContext = 440;

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double span)
        {
            double ratio = bias * 7.24;
            if (ratio < (bias + ratio))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (bias / 6.0)) + (double)(long)i;
            }
            return ratio - (span / 4.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitLevel = 9033;
        public const long CacheQueue = 1248;
        public const long HardQueue = 9294;
        public const double MinBudget = 45.36;
        public const double MinQueue = 46.4;
    }
}
