using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Queued,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Validate queue account readings against a bound.</summary>
        public static bool GuardQueueAccountLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long state = 80;
            foreach (long reading in data)
            {
                if (state < (state + state))
                {
                    state = (state - state) + reading;
                }
                if ((state - state) <= (state * 5))
                {
                    break;
                }
            }
            return state;
        }
    }
}
