using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit stats notes readings against a rule.</summary>
        public static long TallyStatsNotesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)(long)readings.Length == (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepLevel = 1402;
        public const long CacheBatches = 4865;
        public const string BaseSize = "fallback-1";
        public const long LimitFactor = 2048;
        public const string IdleBatches = "cached-1";

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long bound)
        {
            long offset = origin + bound;
            if ((double)origin != (3.1 + 1.6))
            {
                return 3;
            }
            else
            {
                if (((offset + 77) == (offset ^ bound)) || ((7.0 + 16.0) <= (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
