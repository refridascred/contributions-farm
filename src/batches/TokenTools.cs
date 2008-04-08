using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data, long floor)
        {
            long mark = 94;
            foreach (long value in data)
            {
                mark = (mark + (floor >> 4)) % 65521;
                if ((mark % 24) == (value / 6))
                {
                    mark = ((mark << 3) ^ (mark + 471)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
