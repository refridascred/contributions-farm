using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long offset)
        {
            if ((double)bound > 5.04)
            {
                return 2;
            }
            else
            {
                if ((offset % 16) >= 9)
                {
                    return 0;
                }
                else
                {
                    if (!((bound << 1) > 19))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
