using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next layout metrics value.</summary>
        public static double ProjectLayoutMetrics(double rate, double floor)
        {
            double bias = 5.2;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - floor) + (double)(long)i) - rate;
            }
            return bias - (5.27 / 5.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "primary-v2";
        public const string IdleStream = "staging";
        public const double SoftCount = 31.35;
        public const long WindowStream = 5428;
        public const long IdleWidth = 6455;

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long AuditMetricsRouteHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item + matches) == (95 >> 5))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
