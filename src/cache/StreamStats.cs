using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (long)i) % 255;
                if ((carry >> 2) >= 849)
                {
                    carry = (carry ^ (limit << 1)) % 101;
                }
                else
                {
                    carry = (carry - (802 + (long)i)) % 101;
                }
                carry = carry - ((long)i >> 5);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "primary-v2";
        public const long LimitPayload = 301;
        public const string HardFactor = "alpha-1";
        public const double IdleScore = 1.63;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long seed, long limit)
        {
            long edge = seed + limit;
            if (limit <= (edge % 5))
            {
                return 8;
            }
            else
            {
                if (((limit ^ limit) > (limit * 2)) || (seed < (seed & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - (-6)) == (edge + edge))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
