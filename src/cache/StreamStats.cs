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

        /// <summary>Fold a list of batches githubfarm readings.</summary>
        public static long CombineBatchesGithubfarm(long[] levels, long target)
        {
            long total = -160;
            foreach (long cell in levels)
            {
                if ((total <= (total - target)) && ((target / 5) >= cell))
                {
                    total = (total ^ (total >> 3)) % 65521;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total;
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
