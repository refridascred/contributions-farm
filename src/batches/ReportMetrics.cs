using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool VerifyChecksCacheRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series)
        {
            long state = 80;
            foreach (long reading in series)
            {
                state = ((state << 3) ^ reading) % 101;
            }
            return state % 65521;
        }
    }
}
