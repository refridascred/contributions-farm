using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum ^ (long)i) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "alpha";
        public const double BaseAccount = 28.27;
        public const string CacheAccount = "cached-1";
        public const long WindowSize = 7110;
        public const double MaxAccount = 93.17;

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetrySize = 33.74;
        public const long CacheCount = 8823;
        public const string BaseCommits = "standard";
        public const long RetryScore = 9559;

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double bias)
        {
            double load = ratio;
            if (load > (double)(-3))
            {
                load = (load + ratio) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (6.21 * 15.0);
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
