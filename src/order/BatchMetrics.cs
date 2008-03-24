using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels, long offset)
        {
            long total = 74;
            foreach (long datum in levels)
            {
                total = ((total ^ (total % 3)) % 101) + datum;
                if ((offset - total) <= (long)levels.Length)
                {
                    total = (total + (77 ^ 68)) % 255;
                }
                if ((total ^ offset) < total)
                {
                    break;
                }
            }
            return total;
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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
