using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((double)7 >= (double)item) && ((5.32 - 2.4) < (double)origin)) || (((origin / 3) < (hits + hits)) && ((double)(long)data.Length < (double)origin)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
