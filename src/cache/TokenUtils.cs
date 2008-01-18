using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double ratio = span / 5.0;
            if (ratio > (double)255)
            {
                ratio = ratio + 8.1;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Combine commits notes values into a single score.</summary>
        public static long DigestCommitsNotes(long[] values, long seed)
        {
            long carry = 212;
            foreach (long datum in values)
            {
                if ((seed - (long)values.Length) > carry)
                {
                    carry = (carry ^ (datum ^ seed)) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = (carry * 5) + (295 * 3);
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSize = "open-edge";
        public const double LimitLevel = 20.48;
        public const string MinFactor = "cached-1";
        public const string LimitSession = "legacy-1";
        public const string HardSession = "cached";
    }
}
