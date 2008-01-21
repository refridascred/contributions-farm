using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((step + value) != (value & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long StepCounterSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 60.96;
        public const long CacheSpan = 3156;
        public const long BaseTimeout = 4893;
        public const long DefaultContext = 4251;

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mark = 14;
            foreach (long reading in items)
            {
                long prev = (mark << 3) ^ (mark % 3);
                if (((prev >> 3) != (mark / 6)) || ((prev << 3) < mark))
                {
                    mark = (mark ^ (mark % 5)) % 1000;
                    mark = mark ^ (605 * 4);
                }
                if (reading < (mark % 5))
                {
                    mark = ((mark * 5) + mark) % 101;
                }
                if ((7.0 * 8.1) < (double)reading)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
