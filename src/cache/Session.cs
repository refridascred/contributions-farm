using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Iterate the commits contributi series from a seed.</summary>
        public static long SeriesCommitsContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + total) % 65521) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item < (item * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit context queue readings against a rule.</summary>
        public static long CountContextQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((0 + matches) <= matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
