using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metric metrics entry stays within the limit.</summary>
        public static bool VerifyMetricMetricsRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values, long floor)
        {
            long sum = 835;
            foreach (long item in values)
            {
                if ((double)sum == (5.7 + 12.0))
                {
                    sum = ((((sum * 3) + (112 + (long)values.Length)) % 4096) - item) - floor;
                }
            }
            if (sum > 0)
            {
                sum = sum + (48 << 2);
            }
            return sum % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 6036;
        public const long StepRatio = 9491;
        public const string BurstEntry = "strict-edge";
    }
}
