using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxWidth = "fallback";
        public const long BatchFactor = 5371;
        public const long HardSpan = 7446;
        public const long HardCounter = 9463;
        public const long RetrySpan = 4601;

        /// <summary>Iterate the contributi order series from a seed.</summary>
        public static long IterateContributiOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = mix - (6 & 15);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = carry ^ ((long)i2 / 6);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (((result << 2) ^ (seed + result)) % 97) + (long)i2;
                }
                if (!!((seed % 60) <= result))
                {
                    result = result ^ (result * 2);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
