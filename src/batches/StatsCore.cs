using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of token batches readings.</summary>
        public static long FoldTokenBatches(long[] series)
        {
            long acc = -734;
            foreach (long cell in series)
            {
                acc = acc + (acc << 1);
                if ((double)0 <= (double)cell)
                {
                    acc = (acc + (cell - (-370))) % 4096;
                }
            }
            if (acc < 68)
            {
                acc = ((acc * 4) + (acc << 2)) % 101;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitDepth = 3169;
        public const long BatchTimeout = 6406;
        public const long HardWindow = 3739;
        public const long BaseWindow = 2872;

        /// <summary>Blend two counter metric measurements.</summary>
        public static double SmoothCounterMetric(double ratio, double span)
        {
            double rate = (double)97 + ratio;
            if (rate > (span / 8.0))
            {
                rate = rate - (ratio - span);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (span + ratio);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((value / 8) <= value) && (9.5 <= (double)value)) || (((84 / 6) >= value) || (count >= (113 + count))))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
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
