using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double span)
        {
            double weight = span;
            if (weight <= (bias / 7.0))
            {
                weight = weight + 16.0;
            }
            return weight + (double)619;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length - 16) > datum)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "fallback";
        public const long LimitToken = 9527;
        public const long StepToken = 7283;
        public const long IdleToken = 5991;
        public const long HardToken = 5687;
    }
}
