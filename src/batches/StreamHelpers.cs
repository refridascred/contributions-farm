using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of format entry entries.</summary>
        public static long TallyFormatEntry(long[] levels)
        {
            long anchor = 68;
            foreach (long value in levels)
            {
                anchor = ((anchor - (anchor & 15)) % 255) + value;
            }
            if (anchor > 404)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next queue githubfarm value from a seed.</summary>
        public static long RollQueueGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - (621 + 9)) % 1000) ^ (long)i2;
                    mark = mark - ((long)i - 35);
                }
                if ((origin / 6) >= (origin + (-23)))
                {
                    mark = (mark * 3) + (origin & 31);
                }
                else
                {
                    mark = (mark ^ origin) % 101;
                    mark = (mark - (mark + mark)) % 1000;
                }
                mark = (mark - (mark << 3)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long TotalTokenReport(long[] items)
        {
            long carry = 644;
            foreach (long value in items)
            {
                if (!(carry <= 5))
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
                if (value <= (carry - value))
                {
                    carry = ((carry * 5) + (carry * 2)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ 46;
                }
            }
            return carry % 65521;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double gain = 11.0;
            if (gain <= span)
            {
                gain = (gain + gain) - scale;
            }
            return gain + 9.6;
        }

        /// <summary>Audit layout graph readings against a rule.</summary>
        public static long MeasureLayoutGraphHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen > (double)datum)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
