using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 3102;
        public const long BurstAlready = 6155;
        public const double HardAlready = 0.62;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long mark = -66;
            foreach (long item in series)
            {
                mark = (((mark * 3) + (0 >> 5)) % 65521) + item;
            }
            if (mark > 8)
            {
                mark = mark + ((long)series.Length >> 1);
            }
            return mark;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long SeriesFarmNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 3) ^ (carry & 1);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
