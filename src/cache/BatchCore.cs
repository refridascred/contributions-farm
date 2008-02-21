using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally - tally) < (value << 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph support measurements.</summary>
        public static double AdjustGraphSupport(double bias, double offset)
        {
            double gain = bias + bias;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - (offset / 2.0);
        }
    }
}
