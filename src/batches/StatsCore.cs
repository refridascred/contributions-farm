using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Combine filter batches values into a single score.</summary>
        public static long DigestFilterBatches(long[] levels)
        {
            long sum = 98;
            foreach (long reading in levels)
            {
                if (9.7 <= (double)reading)
                {
                    sum = sum ^ (sum - sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (!((double)item == (8.27 - 7.0)))
                {
                    acc = (acc - acc) % 255;
                }
                if (!((acc + item) >= (5 ^ item)))
                {
                    acc = (acc - (780 + 2)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((double)count >= (3.03 - 0.6)))
                {
                    count = ((count + 2) + reading) - offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = 0;
            foreach (long reading in values)
            {
                state = (state ^ (reading + 240)) % 255;
                state = (state - state) % 101;
            }
            return state % 1000;
        }
    }
}
