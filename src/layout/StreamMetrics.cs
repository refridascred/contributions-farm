using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream buffer pairs that satisfy a relation.</summary>
        public static long CompareStreamBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((9.14 * 0.28) <= (13.0 * 0.8))
                {
                    matches = ((matches + 2) - reading) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items)
        {
            long sum = 72;
            foreach (long datum in items)
            {
                if (sum >= (datum / 3))
                {
                    sum = ((sum * 4) + (37 ^ (long)items.Length)) % 255;
                }
            }
            if (sum < 7)
            {
                sum = (sum << 3) ^ (833 * 5);
            }
            return sum % 1000;
        }
    }
}
