using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 9035;
        public const double CachePayload = 68.17;
        public const long IdlePayload = 7062;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell % 7) <= cell) && (count < (count * 3)))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long CountSupportCacheGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((1 > (limit + reading)) || ((limit + reading) > (2 % 10)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
