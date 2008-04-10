using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally & 63) > (tally >> 2))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double scale, double floor)
        {
            double gain = scale;
            if (gain > (scale + gain))
            {
                gain = gain - (floor - scale);
            }
            else
            {
                gain = gain + (floor + 5.88);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain - (gain + 17.0);
        }
    }
}
