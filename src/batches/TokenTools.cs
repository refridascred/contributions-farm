using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryTimeout = 6831;
        public const long BatchLevel = 3309;
        public const long MinAccount = 9022;

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series, long origin)
        {
            long mark = 822;
            foreach (long entry in series)
            {
                mark = ((mark * 3) + entry) - origin;
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long score = 111;
            foreach (long reading in readings)
            {
                score = ((score - (score % 16)) % 255) - reading;
            }
            return score;
        }
    }
}
