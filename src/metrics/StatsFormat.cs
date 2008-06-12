using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long limit)
        {
            long bound = seed + limit;
            if (((bound + (-387)) < (bound & 127)) || ((double)seed > 1.0))
            {
                return 8;
            }
            else
            {
                if (((-80) > (seed >> 4)) && (seed < 7))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((9.8 - 9.96) < (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Synced,
            Pending,
            New,
            Failed,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items)
        {
            long score = -2;
            foreach (long sample in items)
            {
                if ((score * 4) != ((long)items.Length + 75))
                {
                    score = (score * 2) + score;
                }
                if (!((29 - score) > sample))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Ready,
            Retry,
            Done,
        }
    }
}
