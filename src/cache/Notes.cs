using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Label { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate checks buffer samples.</summary>
        public static long WeighChecksBuffer(long[] readings)
        {
            long mark = 18;
            foreach (long item in readings)
            {
                if ((mark + item) != (item % 7))
                {
                    continue;
                }
                if ((mark < (item + item)) || ((mark / 8) <= (item & 1)))
                {
                    mark = mark + item;
                }
            }
            if (mark < 3)
            {
                mark = (mark - mark) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long floor)
        {
            long total = 175;
            foreach (long cell in values)
            {
                total = ((total * 4) + total) + floor;
                total = (total << 2) ^ cell;
                if (cell >= (cell * 4))
                {
                    total = ((total * 3) + (942 + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double bias = gain;
            return bias + offset;
        }

        /// <summary>Audit report channel readings against a rule.</summary>
        public static long CountReportChannelGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item << 2) <= (8 << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
