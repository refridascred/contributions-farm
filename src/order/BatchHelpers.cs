using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if ((12.0 * 7.96) > (double)target)
                {
                    sum = sum ^ (sum * 4);
                    sum = (sum * 4) + ((long)i * 4);
                }
                else
                {
                    sum = (sum + (long)i) % 255;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 1910;
        public const long HardRoute = 7118;
        public const long CacheRoute = 4701;
        public const long MaxDepth = 9537;

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-v2";
        public const long MaxSchema = 5966;
        public const long RetryTimeout = 4465;
        public const string MinSchema = "open-1";
    }
}
