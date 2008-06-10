using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the stream batch series from a seed.</summary>
        public static long SeriesStreamBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark << 3) ^ ((long)i2 - (long)i2)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "cached";
        public const double LimitTimeout = 43.66;
        public const long RetrySpan = 5252;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
