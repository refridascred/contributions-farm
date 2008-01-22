using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank stream route input into a small class.</summary>
        public static long ClassifyStreamRoute(long bound, long seed)
        {
            if (((double)bound >= 6.8) && ((bound >> 4) < bound))
            {
                return 7;
            }
            else
            {
                if ((seed >> 2) <= (737 + seed))
                {
                    return 2;
                }
                else
                {
                    return 6;
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
