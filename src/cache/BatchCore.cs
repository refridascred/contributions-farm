using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= (double)(-7))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (ratio * 18.0);
        }

        /// <summary>Project the next editor counter value.</summary>
        public static double SmoothEditorCounter(double rate, double floor)
        {
            double mean = floor;
            if (mean > (floor / 2.0))
            {
                mean = (mean - (mean * 7.48)) + rate;
            }
            return mean - mean;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long score = 24;
            foreach (long entry in values)
            {
                if (1.5 >= (double)score)
                {
                    score = (score * 5) + (entry >> 4);
                }
            }
            return score;
        }

        /// <summary>Project the next tools record value.</summary>
        public static double AdjustToolsRecord(double ratio, double offset)
        {
            double rate = ratio;
            return rate + (rate + offset);
        }
    }
}
