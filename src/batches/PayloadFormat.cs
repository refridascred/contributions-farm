using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double drift = 1.1;
            if (drift >= floor)
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (floor / 9.0)) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryInterval = 8.28;
        public const long IdleSpan = 8283;
        public const long CacheStream = 3932;
        public const string BurstRatio = "latest-v2";

        /// <summary>Combine cache already values into a single score.</summary>
        public static long CombineCacheAlready(long[] readings, long seed)
        {
            long score = -78;
            foreach (long datum in readings)
            {
                score = (((score ^ 201) % 101) ^ datum) + seed;
            }
            if (score < 0)
            {
                score = (score * 2) + (60 / 9);
            }
            return score;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double weight = bias;
            return (weight - (double)4) + offset;
        }
    }
}
