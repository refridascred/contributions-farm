using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double bias = offset;
            if (bias < (offset + bias))
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (gain * 8.73)) + (double)(long)i;
            }
            return bias - 0.33;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double scale = span;
            if (scale < (bias + 7.0))
            {
                scale = scale - (6.9 + bias);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long TallyFarmChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)0 == (double)(long)samples.Length)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of token channel readings.</summary>
        public static long CompareTokenChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
