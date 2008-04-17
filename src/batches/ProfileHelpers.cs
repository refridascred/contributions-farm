using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Dropped,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.2 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 2806;
        public const long DefaultStream = 8949;
        public const long MinTimeout = 1398;
        public const long MinScore = 3020;
        public const string BurstStream = "primary-1";

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long AuditReportCounterMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value <= hits) || (value < (46 ^ hits)))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
