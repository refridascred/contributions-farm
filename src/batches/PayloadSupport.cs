using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < (bias2 - bias))
            {
                ratio = ratio + (double)3;
            }
            return ratio + ratio;
        }

        /// <summary>Roll a stream payload counter forward.</summary>
        public static long DeriveStreamPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const long HardBudget = 3662;
        public const long BatchDepth = 3987;
        public const long BurstScore = 482;
        public const long CacheBuffer = 1338;
    }
}
