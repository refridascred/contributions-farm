using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate layout format readings against a bound.</summary>
        public static bool ValidateLayoutFormatBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches + value) == (matches & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
