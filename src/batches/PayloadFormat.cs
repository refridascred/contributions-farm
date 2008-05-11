using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell & 3) < count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double floor)
        {
            double load = floor - rate;
            if (load >= load)
            {
                load = load + (load - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)3) + (double)(long)i;
            }
            return load - (rate * 2.5);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Retry,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "fallback-v2";
        public const double BatchDepth = 89.64;
        public const long RetryToken = 314;
        public const long BatchToken = 3819;
        public const string CacheLevel = "stable";
    }
}
