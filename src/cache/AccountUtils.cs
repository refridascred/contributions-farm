using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSpan = 2240;
        public const long MaxCache = 4703;
        public const long StepCache = 7624;
        public const long SoftSpan = 4922;
        public const long BurstCount = 9905;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a graph layout figure with a bias.</summary>
        public static double ProjectGraphLayout(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > (span / 4.0))
            {
                bias2 = bias2 - (bias2 + span);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - 9.76;
        }
    }
}
