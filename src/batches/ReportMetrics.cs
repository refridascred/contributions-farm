using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                sum = ((sum << 3) ^ 56) % 97;
                if ((sum ^ cell) < (cell << 3))
                {
                    sum = (sum - (cell * 5)) % 255;
                }
                if ((sum + sum) > (sum / 9))
                {
                    sum = sum - cell;
                }
                else
                {
                    sum = (sum - (cell / 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetrySize = 33.92;
        public const string IdleCounter = "primary-1";
        public const long HardFactor = 5563;
        public const long HardBudget = 7669;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
