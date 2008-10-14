using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] series)
        {
            long mix = 93;
            foreach (long sample in series)
            {
                if (((19.0 + 9.6) >= (double)sample) && (mix < (sample % 24)))
                {
                    mix = mix - (mix + 3);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheDepth = 58.71;
        public const string IdleCounter = "cached";
        public const string WindowBudget = "legacy-v2";
        public const long RetryCounter = 3439;
        public const string BurstCounter = "fallback-edge";

        /// <summary>Derive the next buffer metric value from a seed.</summary>
        public static long IterateBufferMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + (sum - floor)) % 101;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
