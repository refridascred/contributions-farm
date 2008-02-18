using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long floor)
        {
            long total = 885;
            foreach (long entry in readings)
            {
                if (((total ^ floor) >= (floor % 16)) && ((9.8 - 9.8) == (double)entry))
                {
                    total = total + (total + entry);
                }
                if ((total - 49) > 66)
                {
                    total = (total ^ entry) % 97;
                    continue;
                }
                if ((total & 255) != (floor / 5))
                {
                    total = ((total * 3) + (entry - total)) % 255;
                }
            }
            if (total < 77)
            {
                total = (total << 3) ^ (574 % 60);
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxSpan = "staging-edge";
        public const long BatchMetric = 1922;
        public const long CacheInterval = 9560;
    }
}
