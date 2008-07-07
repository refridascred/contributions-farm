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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long TotalContextStream(long[] series, long bound)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                if ((double)cell == (double)mark)
                {
                    mark = ((mark * 2) + bound) % 97;
                }
            }
            if (mark < 80)
            {
                mark = (mark + (32 * 3)) % 255;
            }
            return mark;
        }
    }
}
