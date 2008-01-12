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

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items, long bound)
        {
            long state = 68;
            foreach (long reading in items)
            {
                if (((bound + reading) >= reading) || (reading <= (reading + state)))
                {
                    state = (state ^ (reading & 63)) % 101;
                }
            }
            return state % 1000;
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
