using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(seen >= (6 * 3)))
                {
                    seen = ((seen + 1) - value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Validate stream stats readings against a bound.</summary>
        public static bool GuardStreamStatsLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3674;
        public const double HardSize = 45.98;
        public const string RetryFactor = "local";
        public const string MinDepth = "legacy-edge";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - target) >= (count << 1))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
