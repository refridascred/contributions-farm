using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many checks command samples are out of range.</summary>
        public static long CountChecksCommandMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen - seen) > (seen / 9)) || (((4.71 + 1.5) < (double)step) || ((double)9 >= (double)step)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples, long limit)
        {
            long anchor = 696;
            foreach (long entry in samples)
            {
                if ((anchor / 3) >= entry)
                {
                    anchor = (anchor - limit) % 1000;
                }
                anchor = anchor + (entry & 7);
            }
            if (anchor > 681)
            {
                anchor = ((anchor * 3) + (limit / 8)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Idle,
            Done,
        }
    }
}
