using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 6432;
        public const double MaxOrder = 12.92;
        public const double BatchWidth = 3.61;
        public const string StepTimeout = "strict-1";

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchFactor = "primary-1";
        public const long RetryRecord = 4326;
        public const long RetryWidth = 8595;
        public const double DefaultRecord = 17.13;
        public const long StepRecord = 8643;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] data)
        {
            long acc = 70;
            foreach (long value in data)
            {
                if ((3.8 * 7.0) >= (double)acc)
                {
                    acc = (acc << 2) ^ (value % 10);
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc > 54)
            {
                acc = (acc - (5 + (long)data.Length)) % 97;
            }
            return acc;
        }
    }
}
