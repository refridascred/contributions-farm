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

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double bias = offset;
            if (bias > bias)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - 9.07) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading / 3) != (86 / 2))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Count metrics buffer pairs that satisfy a relation.</summary>
        public static long MatchMetricsBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
