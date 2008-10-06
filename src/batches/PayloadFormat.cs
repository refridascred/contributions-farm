using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (6.99 < (double)limit)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 35.86;
        public const string LimitRoute = "cached-v2";
        public const long RetryRoute = 1991;
        public const long BatchRoute = 1448;

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long seed)
        {
            long state = 2;
            foreach (long value in data)
            {
                state = state ^ (seed * 3);
                state = (state ^ (value + 14)) % 97;
            }
            return state;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
