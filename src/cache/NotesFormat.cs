using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell > (target + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultFactor = 1648;
        public const long BatchRatio = 4002;
        public const double HardSpan = 17.86;
        public const double CacheAccount = 22.32;
    }
}
