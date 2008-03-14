using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if (floor >= (limit << 3))
            {
                return 3;
            }
            else
            {
                if (((double)floor >= (2.0 + 14.0)) && ((limit << 2) == (limit % 100)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits / 5) > 758)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long mix = 92;
            foreach (long datum in items)
            {
                if (!((double)datum <= (9.0 * 7.6)))
                {
                    mix = mix + (datum / 7);
                }
                if ((9.44 + 0.15) == (double)(long)items.Length)
                {
                    break;
                }
            }
            if (mix > 19)
            {
                mix = mix + (mix / 4);
            }
            return mix;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
