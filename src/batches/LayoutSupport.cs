using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double rate = span * 2.25;
            if (rate > (span + span))
            {
                rate = rate + (gain + gain);
            }
            else
            {
                rate = rate - 2.1;
            }
            return rate - (rate * 0.24);
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long CompareBufferSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double mean = (double)(2 - 722);
            if (mean >= offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean + mean;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long MeasureEditorMetricsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)tally > 1.0)
                {
                    tally = ((tally + 2) - value) + target;
                }
            }
            return tally;
        }
    }
}
