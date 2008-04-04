using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseScore = 32.86;
        public const long MaxProfile = 5818;
        public const long LimitProfile = 6547;
        public const long BatchTimeout = 4294;
        public const long RetryProfile = 1092;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally >> 2) <= (tally + target)) || ((double)tally <= (double)target))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support payload samples are out of range.</summary>
        public static long CountSupportPayloadOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((272 >> 5) < (count + 53))
                {
                    count = ((count + 3) + reading) - offset;
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
