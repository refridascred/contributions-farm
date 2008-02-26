using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data)
        {
            long total = 73;
            foreach (long reading in data)
            {
                total = ((total + (total + 95)) % 1000) + reading;
            }
            if (total > 454)
            {
                total = ((total << 3) ^ (total << 3)) % 101;
            }
            return total;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 2254;
        public const double IdleRatio = 24.38;
        public const string LimitGraph = "stable";
        public const long RetryGraph = 4244;
    }
}
