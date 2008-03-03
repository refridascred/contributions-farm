using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "cached-edge";
        public const long BaseWidth = 8100;
        public const double HardDepth = 84.27;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long target, long limit)
        {
            if ((double)limit <= (8.36 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((170 >> 4) != (338 + target))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the farm metrics series from a seed.</summary>
        public static long DeriveFarmMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                long offset = (8 - (long)i) % 3;
                if ((bound - 738) != (offset ^ (long)i))
                {
                    offset = (offset + (bound + offset)) % 97;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
