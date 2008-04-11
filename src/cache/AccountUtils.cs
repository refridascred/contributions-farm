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

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double ProjectReportAccount(double bias, double bias2)
        {
            double ratio = 7.35;
            return (ratio + bias) + bias2;
        }
    }
}
