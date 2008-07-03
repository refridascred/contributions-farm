using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double scale = bias * 7.98;
            if (scale < (1.4 - rate))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (double)830;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (rate / 7.0);
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batches tools sample.</summary>
        public static long LookupBatchesToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels, long origin)
        {
            long mark = 1;
            foreach (long reading in levels)
            {
                if ((double)3 >= (double)mark)
                {
                    mark = (((mark << 3) ^ (mark - (long)levels.Length)) + reading) + origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry % 2) <= (72 + entry))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length != (3.71 - 2.78))
                {
                    count = ((count + 1) + sample) - bound;
                }
            }
            return count;
        }
    }
}
