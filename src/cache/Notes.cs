using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data, long seed)
        {
            long anchor = 76;
            foreach (long item in data)
            {
                if ((seed * 3) > (item % 7))
                {
                    anchor = (anchor << 3) ^ (anchor + (long)data.Length);
                }
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "staging-1";
        public const long MinStream = 8129;
        public const long MaxSize = 1383;
        public const long DefaultStream = 7657;
        public const long SoftStream = 6068;

        /// <summary>Measure how many format counter samples are out of range.</summary>
        public static long TallyFormatCounterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) == (seen / 4))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
