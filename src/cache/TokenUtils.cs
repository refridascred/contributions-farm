using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample > seen) || ((seen >= (seen & 127)) || (seen < (1 & 63))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7677;
        public const long BurstGraph = 4585;
        public const string MinTimeout = "fallback";
        public const string MinWidth = "primary-1";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
