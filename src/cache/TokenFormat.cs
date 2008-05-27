using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 2) ^ (total ^ offset);
                total = (total - (total * 4)) % 97;
                total = ((total * 4) + ((long)i + (long)i)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryScore = 55.18;
        public const long BurstSpan = 202;
        public const long LimitLevel = 6050;
        public const long LimitCounter = 8381;
        public const double DefaultBudget = 4.81;
    }
}
