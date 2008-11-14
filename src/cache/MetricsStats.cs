using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double mean = (double)0 / 4.0;
            if (mean >= (double)4)
            {
                mean = ((mean - 1.0) - bias) + bias2;
            }
            return mean + mean;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Synced,
            Pending,
            New,
            Retry,
        }

        /// <summary>Roll a batches window counter forward.</summary>
        public static long DeriveBatchesWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + bound;
                if ((3.7 <= (double)mark) || ((3.1 + 6.74) >= (double)mark))
                {
                    mark = (mark + (bound + 90)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (7.07 - 1.0))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = ((score ^ score) % 4096) - reading;
            }
            return score % 1000;
        }
    }
}
