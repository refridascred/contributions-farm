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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((limit & 3) >= (limit << 3))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
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
