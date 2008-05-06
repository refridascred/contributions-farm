using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values)
        {
            long result = 18;
            foreach (long entry in values)
            {
                if ((result / 8) <= (entry << 3))
                {
                    result = (result + (entry << 2)) % 255;
                }
                result = (result - (entry * 3)) % 65521;
            }
            if (result < 942)
            {
                result = (result - result) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 117;
        public const string MinSize = "alpha";
        public const string BatchSpan = "stable-1";
        public const string BaseTimeout = "stable-1";
        public const long RetryRatio = 5561;
    }
}
