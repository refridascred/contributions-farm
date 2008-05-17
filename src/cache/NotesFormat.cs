using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long origin, long target)
        {
            if (target >= (origin + target))
            {
                return 5;
            }
            else
            {
                if (((origin + (-79)) <= (2 * 2)) || (1 < target))
                {
                    return 0;
                }
                else
                {
                    if ((target - origin) != (205 + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double rate = (double)901 + (double)933;
            if (rate <= floor)
            {
                rate = rate + (ratio * 11.0);
            }
            else
            {
                rate = rate - (ratio * 9.28);
            }
            return rate + 2.0;
        }
    }
}
