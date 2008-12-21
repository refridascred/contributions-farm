using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of stats command readings.</summary>
        public static long OverlapStatsCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 3976;
        public const double LimitAlready = 11.08;
        public const long CacheAlready = 7942;
        public const long CacheScore = 8624;
        public const long BatchAlready = 3648;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
