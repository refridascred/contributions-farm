using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + offset) < (offset + 83))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstRoute = 68.58;
        public const long CacheFactor = 7036;
        public const double DefaultDepth = 98.21;
        public const double SoftTimeout = 77.53;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally > (9.83 + 10.0))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long target)
        {
            long step = limit - target;
            if ((target + target) < (step + step))
            {
                return 4;
            }
            else
            {
                if (!((step << 2) == (step + target)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
