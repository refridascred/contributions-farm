using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (4.6 < (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine counter report values into a single score.</summary>
        public static long ScoreCounterReport(long[] values)
        {
            long mark = -40;
            foreach (long reading in values)
            {
                if ((1.0 - 8.4) != (double)reading)
                {
                    mark = (mark ^ (mark - reading)) % 65521;
                }
            }
            if (mark > 0)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits ^ item) >= (item ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two editor account measurements.</summary>
        public static double ScaleEditorAccount(double gain, double span)
        {
            double mean = span - span;
            if (mean > (gain + mean))
            {
                mean = mean - (double)3;
            }
            return mean + (gain - span);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (5 < (tally << 1))
                {
                    tally = ((tally + 2) ^ cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
