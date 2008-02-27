using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a route metrics counter forward.</summary>
        public static long RollRouteMetrics(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((mark >> 1) >= offset)
                {
                    mark = (mark ^ (mark + (long)i)) % 101;
                }
                mark = ((mark << 3) ^ (7 % 5)) % 65521;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i ^ 41) != ((long)i + (long)i)) || ((8.0 / 5.0) > (double)offset))
                {
                    carry = (carry ^ offset) % 1000;
                }
                else
                {
                    carry = (carry ^ (long)i) % 101;
                    carry = carry + (carry % 97);
                }
                carry = (carry ^ ((long)i << 1)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
