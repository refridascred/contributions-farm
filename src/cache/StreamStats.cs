using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool ValidateChecksAccountLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the account format entries that pass the check.</summary>
        public static long AuditAccountFormatHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((5 + count) >= (count + sample))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (2.0 < (double)sample)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultInterval = "legacy";
        public const long BaseEditor = 9973;
        public const long SoftEditor = 5502;
        public const long BatchTimeout = 6379;
        public const double MaxCount = 23.91;
    }
}
