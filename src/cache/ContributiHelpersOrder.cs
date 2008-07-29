using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 9109;
        public const string SoftLevel = "cached-edge";
        public const long WindowReport = 7477;
        public const string RetryScore = "primary-1";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long acc = -217;
            foreach (long sample in items)
            {
                acc = (((acc << 3) ^ 58) % 97) ^ sample;
            }
            if (acc < (-38))
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Queued,
            Ready,
        }
    }
}
