using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryBudget = "strict-v2";
        public const long IdleRatio = 9994;
        public const string CacheRatio = "fallback";

        /// <summary>Iterate the profile metric series from a seed.</summary>
        public static long SeriesProfileMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum << 2) ^ step) % 4096;
                sum = ((sum << 2) ^ (long)i) % 97;
                if (((long)i - 2) >= (7 >> 1))
                {
                    sum = (sum + (step / 8)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
