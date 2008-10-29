using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 3484;
        public const long LimitScore = 2623;
        public const long LimitBuffer = 3154;
        public const string MaxSize = "fallback-edge";
        public const string MaxBuffer = "primary-1";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 12) <= matches)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
