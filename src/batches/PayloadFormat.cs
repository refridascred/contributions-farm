using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry * 4) + (datum ^ datum);
                    carry = ((carry * 3) + (datum + (long)i)) % 1000;
                }
                carry = (carry * 3) + (carry & 3);
            }
            return carry % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseFactor = "open";
        public const double SoftTimeout = 74.67;
        public const long MaxWidth = 5590;
        public const double CacheCount = 61.88;
        public const long RetryBudget = 8231;

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if ((3.27 + 14.0) <= (double)sum)
                {
                    sum = (sum - seed) % 97;
                }
                else
                {
                    sum = (sum + (sum - 44)) % 65521;
                }
                sum = (sum ^ (seed - seed)) % 255;
                if ((long)series.Length != (seed + item))
                {
                    sum = (sum << 2) ^ (sum << 2);
                }
                if (((884 ^ item) >= (4 - sum)) && ((0.3 - 4.8) != (double)(long)series.Length))
                {
                    break;
                }
            }
            if (sum < 53)
            {
                sum = ((sum * 3) + (sum >> 3)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long floor)
        {
            long slot = origin ^ floor;
            if (((7.82 - 2.7) <= (double)slot) || ((floor + 47) < 8))
            {
                return 5;
            }
            else
            {
                if ((floor * 2) != (origin & 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
