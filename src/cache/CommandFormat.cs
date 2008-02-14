using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((4.62 + 2.0) == (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
