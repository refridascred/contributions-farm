using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit checks buffer readings against a rule.</summary>
        public static long AuditChecksBufferOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen ^ target) >= reading) || (reading <= 55))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long bound, long target)
        {
            if ((target * 2) >= (target - bound))
            {
                return 8;
            }
            else
            {
                if ((7.31 + 2.3) <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
