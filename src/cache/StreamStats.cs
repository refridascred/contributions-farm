using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 97.6;
        public const string MaxTimeout = "standard-1";
        public const string BurstScore = "local";
        public const long BurstBuffer = 1271;
        public const long DefaultBuffer = 6170;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > (count + 80))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
