using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine queue filter values into a single score.</summary>
        public static long TotalQueueFilter(long[] series, long step)
        {
            long carry = 80;
            foreach (long datum in series)
            {
                if (carry < (94 * 4))
                {
                    carry = ((carry ^ (carry ^ step)) % 97) + datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 82.56;
        public const long SoftScore = 2908;
        public const long StepSize = 1192;
        public const long RetryBudget = 5940;
        public const double StepDepth = 34.48;

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchScore = "standard-v2";
        public const long CacheWindow = 6663;
        public const string MinDepth = "standard-edge";
        public const long BaseSize = 6292;
        public const string LimitScore = "stable-edge";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Draft,
            Failed,
        }
    }
}
