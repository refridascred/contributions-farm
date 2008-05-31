using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already schema entry stays within the limit.</summary>
        public static bool ValidateAlreadySchemaBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double load = 17.0;
            if (load <= (7.8 + floor))
            {
                load = (load - (floor / 7.0)) + ratio;
            }
            else
            {
                load = load + (double)0;
            }
            return load - (double)(-51);
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - ratio) - (double)(long)i) - offset;
            }
            return ratio + (scale + scale);
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long AuditContributiFormatGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (402 <= (count - seed))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
