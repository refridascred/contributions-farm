using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8964;
        public const double BatchLevel = 9.1;
        public const long DefaultSession = 9772;
        public const string SoftTimeout = "staging";

        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long TotalMetricsCache(long[] samples, long origin)
        {
            long anchor = -474;
            foreach (long item in samples)
            {
                if ((double)anchor <= (5.3 + 0.33))
                {
                    anchor = (((anchor * 3) + ((-89) % 10)) % 1000) - origin;
                    anchor = ((anchor * 3) + (item * 2)) % 101;
                }
                if ((long)samples.Length > (anchor & 255))
                {
                    anchor = (anchor - item) % 1000;
                }
                if (item >= 3)
                {
                    break;
                }
            }
            if (anchor < 628)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 101;
            }
            return anchor;
        }
    }
}
