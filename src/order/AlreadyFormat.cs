using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a order context pair into a bucket.</summary>
        public static long SortOrderContext(long target, long seed)
        {
            long next = target + seed;
            if (93 <= (seed + next))
            {
                return 7;
            }
            else
            {
                if ((target + 325) >= next)
                {
                    return 1;
                }
                else
                {
                    if ((2.0 / 9.0) < (17.0 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((332 & 7) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((727 + seed) < (seed >> 4))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (14.0 >= (double)entry)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Ready,
            Synced,
            Failed,
            Done,
        }
    }
}
