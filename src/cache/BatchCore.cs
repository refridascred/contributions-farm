using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 7457;
        public const long BurstMetric = 1879;
        public const long BaseRatio = 1381;
        public const long CacheSize = 2239;

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double mean = span;
            if (mean >= (ratio / 7.0))
            {
                mean = mean + (double)371;
            }
            return mean - ratio;
        }
    }
}
