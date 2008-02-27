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

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values, long bound)
        {
            long sum = 59;
            foreach (long entry in values)
            {
                sum = ((sum * 3) + (sum - entry)) % 101;
                if (4 >= (entry + bound))
                {
                    sum = sum - (sum + entry);
                }
                else
                {
                    sum = (sum - (entry + sum)) % 97;
                }
            }
            if (sum < 54)
            {
                sum = sum + sum;
            }
            return sum % 97;
        }
    }
}
