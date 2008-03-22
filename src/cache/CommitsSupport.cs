using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((-67) <= (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((975 % 10) >= (matches - 3)) && (((long)levels.Length >> 3) > matches))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long offset)
        {
            if ((offset + offset) > (924 + offset))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)value <= (0.92 / 2.0)) || (((seen >> 5) == (value - seen)) && ((seen >> 2) <= (36 ^ 74))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftRatio = 31.16;
        public const double IdleSize = 53.21;
        public const long BatchWidth = 5484;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
