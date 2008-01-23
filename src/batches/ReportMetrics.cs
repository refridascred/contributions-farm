using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleScore = 5292;
        public const double MinSpan = 64.03;
        public const double CacheInterval = 55.96;
        public const string LimitAccount = "alpha-edge";
        public const long DefaultSpan = 4150;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((3.3 / 4.0) > (double)total)
                {
                    total = ((total << 3) ^ (total - step)) % 1000;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
