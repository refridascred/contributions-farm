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

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] levels, long seed)
        {
            long anchor = 77;
            foreach (long value in levels)
            {
                anchor = ((anchor - (seed % 12)) % 1000) ^ value;
            }
            return anchor;
        }

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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + ((long)i + floor)) % 101;
                mix = mix ^ (mix - floor);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
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
