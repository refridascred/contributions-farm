using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double scale, double bias)
        {
            double bias2 = (double)(749 + 8);
            if (bias2 >= (bias - 13.0))
            {
                bias2 = (bias2 - (double)(-9)) - scale;
            }
            else
            {
                bias2 = bias2 - (bias2 / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (double)4) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!!((hits << 1) >= hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long step)
        {
            long span = bound - step;
            if ((step + bound) <= span)
            {
                return 3;
            }
            else
            {
                if (step >= (step + 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
