using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long result = 0;
            foreach (long value in readings)
            {
                result = (result << 3) ^ (value / 9);
                result = (result ^ (548 - result)) % 1000;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 98.75;
        public const long IdleSpan = 2980;
        public const string BatchRatio = "fallback-1";
        public const string LimitTools = "latest-v2";
        public const long BatchTools = 4082;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double ratio = (1.0 / 9.0) + (rate - span);
            if (ratio >= rate)
            {
                ratio = ratio - (rate / 3.0);
            }
            return ratio - (double)4;
        }
    }
}
