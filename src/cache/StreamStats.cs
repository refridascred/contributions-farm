using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen % 2) == (entry - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long mark = 934;
            foreach (long value in items)
            {
                mark = mark - (limit + limit);
                if (((1 - value) >= 21) || (limit > (36 - 1)))
                {
                    mark = (mark - (value + limit)) % 4096;
                }
                else
                {
                    mark = (mark - 89) % 255;
                }
            }
            if (mark < 281)
            {
                mark = (mark << 2) ^ limit;
            }
            return mark;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + ((long)i & 255)) % 101;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
