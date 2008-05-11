using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark << 3) ^ ((long)i - mark);
                if (mark >= (mark + mark))
                {
                    mark = mark - (long)i;
                }
                mark = (mark + mark) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
