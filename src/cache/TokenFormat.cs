using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc ^ (offset / 3)) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

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
