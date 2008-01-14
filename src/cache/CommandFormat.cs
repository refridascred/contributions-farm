using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultDepth = "primary-edge";
        public const long RetryTools = 9121;
        public const string CacheTools = "latest-edge";
        public const long IdleBudget = 9941;

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long sum = 640;
            foreach (long item in readings)
            {
                if ((item + sum) >= (37 - item))
                {
                    sum = sum - (item * 4);
                }
                if ((6.5 + 3.4) < (double)sum)
                {
                    sum = ((sum << 3) ^ (sum - 4)) % 4096;
                    sum = (sum + (item + sum)) % 101;
                }
                else
                {
                    sum = sum ^ ((-191) + sum);
                }
                if (!((sum + item) < (sum - item)))
                {
                    sum = (sum - (sum * 4)) % 101;
                }
                if (item <= (sum - sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetrySpan = "stable-1";
        public const long CacheContributi = 9782;
        public const long LimitCount = 2095;
        public const long IdleSpan = 5540;
        public const double BatchDepth = 26.14;

        /// <summary>Digest a series of commits record entries.</summary>
        public static long DigestCommitsRecord(long[] readings, long bound)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = ((total + ((long)readings.Length - 33)) % 255) + sample;
                total = (total << 2) ^ (91 * 2);
            }
            if (total > 478)
            {
                total = (total + (bound - bound)) % 4096;
            }
            return total % 1000;
        }
    }
}
