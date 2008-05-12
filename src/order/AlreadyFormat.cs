using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target % 60) > (tally & 255))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Audit cache graph readings against a rule.</summary>
        public static long MeasureCacheGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally / 7) >= (item - item)) && ((item << 1) <= tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((limit / 7) > limit))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + count) < (count + offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
