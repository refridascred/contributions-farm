using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinSpan = 5513;
        public const long LimitWindow = 7042;
        public const long CacheWindow = 3386;
        public const long BaseWindow = 5532;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit session token readings against a rule.</summary>
        public static long TallySessionTokenOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)99 >= (double)matches))
                {
                    matches = ((matches + 1) ^ datum) - seed;
                }
            }
            return matches;
        }
    }
}
