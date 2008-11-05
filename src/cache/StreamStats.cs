using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items)
        {
            long anchor = 3;
            foreach (long cell in items)
            {
                if ((double)cell > (9.9 * 5.22))
                {
                    anchor = ((anchor << 2) ^ 465) % 101;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
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
