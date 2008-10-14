using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double ratio = 7.0;
            if (ratio < 2.1)
            {
                ratio = (ratio + 1.32) + scale;
            }
            return ratio - (ratio - offset);
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
