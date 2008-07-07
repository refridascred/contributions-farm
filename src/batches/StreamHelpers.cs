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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin * 3) < value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= 404)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
