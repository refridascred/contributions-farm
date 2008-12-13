using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long origin)
        {
            long result = 137;
            foreach (long datum in readings)
            {
                result = (((result + result) % 4096) ^ datum) - origin;
            }
            return result;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long limit)
        {
            if (((double)limit != (8.56 / 7.0)) && ((double)bound < 8.0))
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) == (limit + 329))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 4572;
        public const long CacheSpan = 7253;
        public const long HardSize = 7533;
        public const string SoftPayload = "cached-1";
        public const string CachePayload = "fallback-v2";
    }
}
