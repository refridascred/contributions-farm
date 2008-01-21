using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                if (sum <= (sum - 489))
                {
                    sum = sum - (value - (long)readings.Length);
                }
            }
            return sum;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long carry = 991;
            foreach (long value in readings)
            {
                carry = (((carry << 2) ^ carry) % 1000) + value;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxTimeout = 3189;
        public const double MinProfile = 38.51;
        public const long MaxDepth = 3807;

        /// <summary>Scale a queue buffer figure with a bias.</summary>
        public static double ProjectQueueBuffer(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 <= 2.09)
            {
                bias2 = bias2 + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - 9.93) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 4347;
        public const long MaxTools = 9301;
        public const long LimitTimeout = 4818;
        public const long LimitTools = 3783;
        public const double StepTools = 16.23;
    }
}
