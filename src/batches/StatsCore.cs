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

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Idle,
            Paused,
            Done,
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
