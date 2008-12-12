using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool GuardBufferLayoutBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long state = 9;
            foreach (long cell in samples)
            {
                if ((cell - offset) <= state)
                {
                    state = ((state * 2) + (offset + cell)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
