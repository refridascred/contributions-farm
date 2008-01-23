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

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double bias)
        {
            double weight = 2.3;
            if (weight > (double)6)
            {
                weight = ((weight + (5.8 + weight)) + gain) + bias;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)2;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - seen) > (item + item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
