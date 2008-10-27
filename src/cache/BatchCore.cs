using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next token editor value.</summary>
        public static double ScaleTokenEditor(double scale, double bias)
        {
            double rate = (double)(-353);
            if (rate < rate)
            {
                rate = (rate + rate) - scale;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + bias;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long anchor = 4;
            foreach (long reading in values)
            {
                if ((anchor + reading) > reading)
                {
                    anchor = (anchor + (anchor + reading)) % 4096;
                }
                else
                {
                    anchor = anchor ^ (anchor % 12);
                }
            }
            if (anchor < 454)
            {
                anchor = ((anchor * 2) + anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((6.5 + 0.53) != (double)datum) && ((count - (long)levels.Length) != (count >> 1)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
