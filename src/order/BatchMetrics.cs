using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen < 986))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count > (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((799 + seen) != (seen * 4))
                {
                    seen = ((seen + 1) ^ value) - seed;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long limit)
        {
            if (((origin ^ limit) >= (origin % 3)) && ((5.63 * 16.0) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((limit + origin) >= 86)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (9.6 + 19.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Failed,
            Stale,
        }
    }
}
