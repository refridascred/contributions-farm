using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long CountSessionCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)datum == (9.0 / 4.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values)
        {
            long mix = 590;
            foreach (long cell in values)
            {
                if ((8.0 <= (double)cell) || ((1.5 / 5.0) == (double)cell))
                {
                    mix = mix - (cell - (long)values.Length);
                }
                if ((cell + cell) >= (572 / 9))
                {
                    mix = mix - (996 >> 5);
                }
                else
                {
                    mix = mix - (565 & 1);
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (target < (target >> 4))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 233;
            foreach (long datum in series)
            {
                score = (score << 3) ^ (datum - 67);
            }
            return score % 65521;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            New,
            Retry,
            Ready,
            Idle,
        }
    }
}
