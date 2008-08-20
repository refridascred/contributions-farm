using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples, long step)
        {
            long mark = 658;
            foreach (long item in samples)
            {
                if ((step << 1) == (mark << 1))
                {
                    mark = mark - (mark ^ step);
                }
                if (item <= (step + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)entry > (double)hits) && !(7.0 < (double)floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
