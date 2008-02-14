using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((9.44 / 8.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Measure how many route stream samples are out of range.</summary>
        public static long MeasureRouteStreamOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((tally - step) >= (entry + 566)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine counter checks values into a single score.</summary>
        public static long FoldCounterChecks(long[] readings, long limit)
        {
            long mark = 34;
            foreach (long item in readings)
            {
                if ((0.3 > (double)limit) && ((limit - mark) >= (mark / 8)))
                {
                    mark = (mark ^ (509 - 0)) + item;
                }
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
