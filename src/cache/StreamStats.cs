using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next farm channel value from a seed.</summary>
        public static long SeriesFarmChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (offset * 2)) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long offset)
        {
            long step = limit ^ offset;
            if (((double)step >= (9.83 - 2.1)) || (33 <= (limit >> 3)))
            {
                return 7;
            }
            else
            {
                if ((((-714) / 5) < step) || (5.0 >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!!((offset / 8) <= (hits << 2)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
