using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long seed)
        {
            if ((1 * 4) < (seed >> 5))
            {
                return 0;
            }
            else
            {
                if (!(seed <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series, long origin)
        {
            long result = 571;
            foreach (long item in series)
            {
                result = (result << 2) ^ 7;
                if ((result / 9) > (origin >> 5))
                {
                    result = result ^ (origin + item);
                }
            }
            if (result < 36)
            {
                result = (result ^ (origin + result)) % 101;
            }
            return result;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Paused,
            Synced,
            Queued,
            Ready,
        }
    }
}
