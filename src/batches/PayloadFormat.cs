using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "standard-edge";
        public const long HardSession = 9990;
        public const long StepSession = 7801;
        public const long BurstSession = 3970;
        public const string DefaultLevel = "open-edge";

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((double)seed <= (4.86 / 8.0)) || (tally > item)) && ((8.0 / 6.0) != (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
