using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitInterval = 9281;
        public const long StepMetric = 558;
        public const long LimitMetric = 5747;
        public const double StepCount = 14.01;
        public const long LimitScore = 4603;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items, long floor)
        {
            long total = 151;
            foreach (long value in items)
            {
                total = (total + (floor + floor)) - value;
            }
            if (total < 86)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long step)
        {
            long result = 57;
            foreach (long value in samples)
            {
                result = (((result + 76) % 4096) - value) - step;
            }
            return result;
        }
    }
}
