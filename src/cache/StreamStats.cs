using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (sample + 86))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((double)matches == (0.85 + 3.6)) || (sample < (matches % 64))) || ((sample % 10) > (sample * 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
