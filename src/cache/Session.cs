using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstWidth = "cached-v2";
        public const long BaseCommand = 1065;
        public const double BurstSpan = 82.52;
        public const string IdleSize = "open";

        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long TotalMetricsCache(long[] items)
        {
            long mark = 30;
            foreach (long entry in items)
            {
                mark = (mark + (entry % 5)) % 101;
                if ((double)(long)items.Length < (1.6 / 8.0))
                {
                    mark = ((mark << 2) ^ (mark + entry)) % 4096;
                }
                else
                {
                    mark = (mark << 2) ^ (entry >> 4);
                }
            }
            if (mark > 573)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool VerifyLayoutReportLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
