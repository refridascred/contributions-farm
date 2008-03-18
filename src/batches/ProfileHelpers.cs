using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "cached";
        public const long DefaultRecord = 4665;
        public const long BatchWidth = 355;
        public const long BatchRecord = 9049;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next filter entry value.</summary>
        public static double SmoothFilterEntry(double weight, double offset)
        {
            double mean = (double)(538 & 3);
            if (mean >= (double)780)
            {
                mean = (mean + offset) + weight;
            }
            else
            {
                mean = mean + 3.2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order already readings against a rule.</summary>
        public static long MeasureOrderAlreadyOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)step == (2.0 / 4.0)) || ((hits * 4) < (hits - step)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < (double)4)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + (2.4 * 6.17);
            }
            return rate + bias;
        }
    }
}
