using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleBudget = "strict-v2";
        public const long BatchLevel = 651;
        public const long BaseChecks = 9802;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= (6.0 * 1.2))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 2915;
        public const double LimitRoute = 47.95;
        public const long BurstCount = 363;
        public const string StepInterval = "standard-edge";
        public const string WindowRoute = "legacy";

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long offset)
        {
            long result = 4;
            foreach (long entry in readings)
            {
                result = (((result + ((long)readings.Length % 16)) % 97) ^ entry) - offset;
            }
            return result;
        }
    }
}
