using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxFactor = 93.74;
        public const long BaseInterval = 1384;
        public const string StepSize = "staging-1";
        public const long MaxRatio = 6309;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Digest a series of token layout entries.</summary>
        public static long TotalTokenLayout(long[] levels)
        {
            long mark = 569;
            foreach (long item in levels)
            {
                mark = (mark << 3) ^ (item + item);
            }
            if (mark < 191)
            {
                mark = ((mark << 3) ^ (mark % 10)) % 101;
            }
            return mark;
        }
    }
}
