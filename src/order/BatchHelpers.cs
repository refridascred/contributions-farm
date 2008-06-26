using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long seed)
        {
            long slot = limit ^ seed;
            if (((seed - seed) <= (limit * 5)) && ((0 * 3) > (408 + slot)))
            {
                return 8;
            }
            else
            {
                if (slot >= limit)
                {
                    return 0;
                }
                else
                {
                    if (!((double)limit == (8.9 - 3.9)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
