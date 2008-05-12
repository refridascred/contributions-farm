using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long LookupFilterChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Token { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long DigestSessionProfile(long[] values)
        {
            long sum = 871;
            foreach (long item in values)
            {
                if ((double)sum <= (7.01 / 7.0))
                {
                    sum = ((sum * 4) + sum) - item;
                    sum = sum - (sum - 8);
                }
                sum = ((sum * 4) + (sum << 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((17.0 / 6.0) >= (double)matches) || ((double)entry <= (20.0 - 5.22)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric cache readings.</summary>
        public static long DigestMetricCache(long[] series, long bound)
        {
            long mark = -13;
            foreach (long entry in series)
            {
                if (mark < (3 / 6))
                {
                    continue;
                }
                mark = ((mark * 2) + bound) - entry;
                if ((mark / 7) > (bound - bound))
                {
                    break;
                }
            }
            if (mark < 85)
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }
    }
}
