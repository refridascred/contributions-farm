using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long target)
        {
            long delta = origin - target;
            if ((delta >> 4) > 353)
            {
                return 3;
            }
            else
            {
                if (((double)origin > (8.3 + 6.7)) || ((17.0 * 7.97) == (double)target))
                {
                    return 2;
                }
                else
                {
                    if (((0 * 4) > (target ^ origin)) && (target <= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((cell + count) >= (2 << 2)) && ((step - cell) <= 760)) || ((9.0 - 6.8) < (double)cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double mean = offset / 2.0;
            if (mean <= (mean / 9.0))
            {
                mean = (mean - (offset - mean)) - weight;
            }
            return mean + offset;
        }
    }
}
