using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two queue command measurements.</summary>
        public static double BlendQueueCommand(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + gain2) - (double)(long)i;
            }
            return gain2 - floor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen & 63) <= (sample << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long bound)
        {
            if ((double)limit <= (6.36 - 4.5))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) == (limit - bound))
                {
                    return 1;
                }
                else
                {
                    if (((limit - bound) <= (bound % 8)) && ((7.7 * 11.0) != (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit - bound) >= (bound % 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long AuditRecordContributiOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(0.5 < (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
