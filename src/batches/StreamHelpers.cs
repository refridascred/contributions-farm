using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many batches githubfarm samples are out of range.</summary>
        public static long MeasureBatchesGithubfarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value * 5) <= (matches / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item + item) >= item) && ((seen << 2) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Synced,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
