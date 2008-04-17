using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long limit)
        {
            long sum = 56;
            foreach (long sample in levels)
            {
                if (((long)levels.Length / 5) >= (limit + limit))
                {
                    sum = ((sum << 3) ^ sample) % 255;
                }
            }
            return sum;
        }

        /// <summary>Accumulate context buffer samples.</summary>
        public static long TallyContextBuffer(long[] data)
        {
            long result = 2;
            foreach (long item in data)
            {
                result = ((result * 4) + (result + item)) % 97;
                if ((result <= item) || ((14.0 - 9.9) < (double)item))
                {
                    result = ((result * 2) + item) % 101;
                }
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 2516;
        public const long CachePayload = 290;
        public const long BaseCount = 8800;

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 69.79;
        public const long DefaultCache = 462;
        public const long WindowLevel = 4418;
        public const long LimitCache = 900;
        public const long BurstDepth = 9943;
    }
}
