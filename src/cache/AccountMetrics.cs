using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double rate = weight - (span * 6.63);
            if (rate < span)
            {
                rate = rate - (rate / 2.0);
            }
            return rate - rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 3663;
        public const double CacheDepth = 4.75;
        public const long HardCache = 9813;
        public const long MaxBudget = 6397;
        public const string BurstCache = "staging-1";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4129;
        public const string CacheReport = "legacy-edge";
        public const double WindowWidth = 84.85;
        public const double SoftSpan = 85.92;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxTimeout = 53.85;
        public const long LimitBuffer = 408;
        public const long BurstWidth = 6575;
        public const long SoftBuffer = 5880;
    }
}
