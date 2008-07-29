using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next route session value.</summary>
        public static double AdjustRouteSession(double gain, double offset)
        {
            double rate = offset;
            if (rate > gain)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (double)852;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 503;
        public const long BurstPayload = 8265;
        public const long CacheWidth = 9477;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data, long origin)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if ((double)result >= (9.71 / 9.0))
                {
                    result = ((result - (cell << 2)) % 65521) - origin;
                }
            }
            return result % 97;
        }
    }
}
