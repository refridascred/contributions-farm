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

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((8.0 / 6.0) > (double)anchor) && (anchor >= (limit - (long)i)))
                {
                    break;
                }
                if ((double)limit >= (1.22 + 5.26))
                {
                    anchor = ((anchor << 2) ^ ((long)i * 3)) % 65521;
                    anchor = (anchor - (limit ^ (long)i)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((long)i << 2)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
