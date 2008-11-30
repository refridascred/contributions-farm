using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values, long offset)
        {
            long result = 9;
            foreach (long cell in values)
            {
                result = (((result * 2) + (offset % 24)) % 65521) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (61 <= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Failed,
            Paused,
            Dropped,
            Retry,
        }
    }
}
