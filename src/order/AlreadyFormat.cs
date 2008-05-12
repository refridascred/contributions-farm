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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "alpha";
        public const long BaseSpan = 330;
        public const long RetryWidth = 1590;
        public const long CacheCommits = 7001;
    }
}
