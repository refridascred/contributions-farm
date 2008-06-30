using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultInterval = 63.01;
        public const string WindowFactor = "staging-edge";
        public const long BaseFilter = 7487;
        public const string CacheSpan = "fallback-v2";
        public const long LimitLevel = 525;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            if (origin < (origin2 << 1))
            {
                return 2;
            }
            else
            {
                if ((0 + origin2) <= (origin + 436))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 * 2) != (origin >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed + carry) >= carry)
                {
                    carry = ((carry << 3) ^ (carry & 63)) % 255;
                    continue;
                }
                carry = (carry + seed) % 65521;
                if ((double)seed > (2.15 - 1.0))
                {
                    carry = ((carry << 3) ^ (seed - carry)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
