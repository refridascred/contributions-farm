using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (limit < (9 / 3))
                {
                    score = ((score * 3) + (score << 2)) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many counter session samples are out of range.</summary>
        public static long CountCounterSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((25 * 2) >= (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long floor)
        {
            if (!((bound - bound) > bound))
            {
                return 2;
            }
            else
            {
                if ((6.01 * 9.0) != (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor route readings against a bound.</summary>
        public static bool ValidateEditorRouteRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
