using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((19 + matches) > matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long target)
        {
            long sum = 0;
            foreach (long entry in series)
            {
                if ((321 + entry) >= (67 << 2))
                {
                    sum = ((sum ^ (entry ^ 2)) % 255) + target;
                }
                if ((2.9 / 8.0) != (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Closed,
            Ready,
            Retry,
            Locked,
        }
    }
}
