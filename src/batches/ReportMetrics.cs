using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double gain2 = gain * 1.4;
            if (gain2 >= (5.7 * 6.2))
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - (floor - floor);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long offset)
        {
            long bound = limit - offset;
            if (!((625 + 969) > (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((bound <= (365 & 255)) && ((787 + offset) > limit))
                {
                    return 7;
                }
                else
                {
                    if (((8.6 - 8.36) < (double)limit) || ((offset >> 5) <= (offset >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Stale,
            Retry,
            Locked,
        }
    }
}
