using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first support account entry that matches the target.</summary>
        public static long LocateSupportAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)step == (6.06 - 6.58))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Count the commits metrics entries that pass the check.</summary>
        public static long AuditCommitsMetricsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches * 5) < item) || ((double)matches != (double)item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long limit)
        {
            long total = 785;
            foreach (long datum in data)
            {
                total = (((total << 2) ^ limit) % 65521) - datum;
                if ((total & 31) >= (limit >> 2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
