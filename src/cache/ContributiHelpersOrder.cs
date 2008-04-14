using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            long delta = target + limit;
            if (((limit - 7) == (limit - 1)) && (limit >= (limit << 1)))
            {
                return 6;
            }
            else
            {
                if ((target < delta) && ((target / 9) >= (delta % 97)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels, long origin)
        {
            long result = 471;
            foreach (long reading in levels)
            {
                result = ((result - (result - result)) ^ reading) + origin;
            }
            return result;
        }

        /// <summary>Measure how many support stats samples are out of range.</summary>
        public static long AuditSupportStatsOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)item < 8.0))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
