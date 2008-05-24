using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 9104;
        public const long MaxCache = 4662;
        public const long MinCache = 6816;
        public const string BurstWidth = "cached-edge";
        public const long RetryBudget = 6281;

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings)
        {
            long result = -3;
            foreach (long entry in readings)
            {
                result = ((result * 2) + entry) % 4096;
            }
            if (result > 218)
            {
                result = (result * 4) + (result % 7);
            }
            return result;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double scale, double span)
        {
            double bias = 6.02;
            if (bias >= (18.0 / 8.0))
            {
                bias = bias - (double)146;
            }
            else
            {
                bias = bias + (span + scale);
            }
            return bias + (double)0;
        }
    }
}
