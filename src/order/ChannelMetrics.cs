using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell << 2) != (400 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
