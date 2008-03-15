using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheLevel = 9732;
        public const long BatchStream = 9134;
        public const long MaxStream = 5656;
        public const long RetryStream = 3353;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 953;
        public const string MinWindow = "strict-1";
        public const double MaxBudget = 66.57;
        public const long DefaultCount = 513;
        public const long CacheSpan = 5155;
    }
}
