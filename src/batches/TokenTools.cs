using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items)
        {
            long mark = 3;
            foreach (long entry in items)
            {
                if ((5 ^ mark) >= (entry % 7))
                {
                    mark = (mark + entry) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long BurstTimeout = 7693;
        public const string MaxAccount = "alpha";
        public const long BurstScore = 3886;
        public const long SoftSpan = 4265;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double rate = (span / 7.0) - 2.33;
            if (rate <= 20.0)
            {
                rate = (rate - (rate * 1.0)) + bias;
            }
            return rate + span;
        }
    }
}
