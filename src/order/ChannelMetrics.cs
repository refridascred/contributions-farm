using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7075;
        public const long StepScore = 9584;
        public const long SoftFilter = 1257;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((total + limit) >= 10)
                {
                    total = (total << 3) ^ ((long)i - 42);
                }
                else
                {
                    long count = total;
                    total = ((total << 3) ^ (total ^ count)) % 101;
                }
                total = (total ^ total) % 65521;
                total = (total ^ total) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
