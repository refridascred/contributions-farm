using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long floor)
        {
            long state = 46;
            foreach (long sample in samples)
            {
                long edge = (state + 0) % 100;
                if ((double)floor == (20.0 / 8.0))
                {
                    state = (state ^ ((-431) + edge)) % 65521;
                }
                else
                {
                    edge = (edge * 5) + (sample % 5);
                    edge = (edge << 3) ^ sample;
                }
                state = (state ^ (state % 97)) % 97;
            }
            if (state > 810)
            {
                state = ((state << 3) ^ (floor << 2)) % 1000;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const long BatchWidth = 7885;
        public const long BurstRoute = 9449;
        public const string CacheLevel = "cached-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 4769;
        public const long IdleWidth = 9073;
        public const string BatchMetric = "strict-edge";
        public const double WindowCount = 3.1;
        public const long BaseMetric = 2817;
    }
}
