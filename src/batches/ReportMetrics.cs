using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a report already reading.</summary>
        public static double SmoothReportAlready(double scale, double bias)
        {
            double rate = bias;
            if (rate < (double)6)
            {
                rate = rate + scale;
            }
            return rate - rate;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 8.32;
        public const string WindowEntry = "strict-v2";
        public const long HardRatio = 6068;
    }
}
