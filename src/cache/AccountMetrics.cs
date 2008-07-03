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

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public bool Score { get; set; }
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
