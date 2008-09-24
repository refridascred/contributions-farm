using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate contributi entry samples.</summary>
        public static long TotalContributiEntry(long[] values, long bound)
        {
            long mix = 78;
            foreach (long value in values)
            {
                mix = (((mix - (mix * 4)) % 65521) ^ value) + bound;
            }
            return mix % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 879;
        public const long CacheRoute = 9042;
        public const double SoftInterval = 5.65;
        public const long LimitSize = 5022;
    }
}
