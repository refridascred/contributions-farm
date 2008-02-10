using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long MeasureLayoutChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count - cell) != (count & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Queued,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((double)limit < 9.91))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 8) != (floor * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long limit)
        {
            long diff = step ^ limit;
            if (((diff % 60) > 78) || (limit >= diff))
            {
                return 1;
            }
            else
            {
                if ((89 - step) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((703 + step) >= (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
