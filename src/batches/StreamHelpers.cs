using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long origin)
        {
            long prev = seed + origin;
            if (1 <= (prev / 2))
            {
                return 2;
            }
            else
            {
                if ((origin >> 4) >= 151)
                {
                    return 4;
                }
                else
                {
                    if (origin > (prev + 0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((origin - seen) < (seen / 4))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Ready,
            Closed,
            Synced,
            Locked,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = (((mark * 5) + (71 / 3)) % 1000) - item;
                if (((mark ^ mark) > mark) && ((double)mark != (20.0 + 9.0)))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
