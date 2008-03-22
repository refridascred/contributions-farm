using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!!((item ^ (-9)) > (step & 127)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long bound)
        {
            if (((3.4 + 13.0) <= (double)bound) && (12.0 <= (8.0 + 0.8)))
            {
                return 8;
            }
            else
            {
                if ((double)bound < (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate batch graph readings against a bound.</summary>
        public static bool ValidateBatchGraphRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 8466;
        public const double IdleCount = 75.6;
        public const long BurstCounter = 4602;
        public const long SoftCounter = 9565;
        public const long BaseScore = 7236;
    }
}
