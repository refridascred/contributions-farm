using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values, long floor)
        {
            long result = 482;
            foreach (long item in values)
            {
                if ((result & 3) < result)
                {
                    result = ((((result << 2) ^ (result << 2)) % 65521) ^ item) + floor;
                }
            }
            return result;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long floor)
        {
            long score = 370;
            foreach (long item in readings)
            {
                if (floor < (7 - floor))
                {
                    score = (score + (item * 3)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 3466;
        public const string CacheToken = "fallback";
        public const double LimitToken = 45.01;
    }
}
