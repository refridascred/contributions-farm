using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double bias2 = (double)(10 / 9);
            if (bias2 > (double)295)
            {
                bias2 = ((bias2 + (double)7) - bias) + floor;
            }
            return bias2 - 5.0;
        }

        /// <summary>Blend two filter account measurements.</summary>
        public static double AdjustFilterAccount(double bias, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - mean) + (double)(long)i) - bias;
            }
            return mean - mean;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 7.6) > (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            New,
            Idle,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Active,
            Pending,
            Dropped,
            Closed,
        }
    }
}
