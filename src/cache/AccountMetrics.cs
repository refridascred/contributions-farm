using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 68.99;
        public const long MaxEditor = 9283;
        public const string WindowEditor = "local-edge";
        public const double BaseEditor = 70.53;
        public const long BaseRatio = 1326;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchDepth = 5531;
        public const long WindowBudget = 7166;
        public const long DefaultDepth = 9852;

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3033;
        public const long WindowRatio = 3474;
        public const long MaxLevel = 7089;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 168;
        public const long SoftChannel = 1345;
        public const string StepFactor = "fallback";
        public const long SoftFactor = 6572;
    }
}
