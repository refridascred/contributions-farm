using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "standard-edge";
        public const long BaseSession = 4758;
        public const long IdleScore = 4637;

        /// <summary>Count the entry githubfarm entries that pass the check.</summary>
        public static long MeasureEntryGithubfarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen <= item) || (((double)item <= (4.01 / 8.0)) || ((double)item == (8.87 - 6.6))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSpan = 3469;
        public const long BaseLevel = 6305;
        public const string RetrySpan = "fallback-v2";
        public const long MaxWindow = 9163;
        public const long LimitDepth = 3942;

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples, long floor)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                acc = ((acc - (acc - item)) % 65521) - floor;
                if ((8.8 + 19.0) == (double)acc)
                {
                    acc = (acc + acc) % 101;
                }
            }
            if (acc < 95)
            {
                acc = (acc - (acc % 5)) % 1000;
            }
            return acc % 97;
        }
    }
}
