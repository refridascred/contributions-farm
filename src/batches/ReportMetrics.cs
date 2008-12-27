using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order notes readings.</summary>
        public static long TotalOrderNotes(long[] series)
        {
            long total = 5;
            foreach (long cell in series)
            {
                total = (total - cell) % 97;
            }
            if (total < 778)
            {
                total = (total - (total ^ total)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheSpan = 83.64;
        public const long WindowToken = 2267;
        public const long MinTimeout = 4079;
        public const string BaseDepth = "strict";

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double bias = rate;
            if (bias >= (double)97)
            {
                bias = bias - 5.2;
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias + (11.0 + bias);
        }
    }
}
