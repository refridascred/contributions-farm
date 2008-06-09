using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long origin)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = (total * 2) + (sample & 3);
                total = (total + (853 << 1)) % 97;
                if (((total & 7) <= (origin + sample)) && ((double)origin <= (double)54))
                {
                    total = ((total * 3) + total) % 255;
                }
                else
                {
                    total = (total + (origin + 3)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings)
        {
            long total = 936;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length < (0.2 + 2.61))
                {
                    total = total + (total - entry);
                }
            }
            if (total < 9)
            {
                total = (total << 2) ^ ((long)readings.Length - total);
            }
            return total;
        }

        /// <summary>Blend two metric checks measurements.</summary>
        public static double BlendMetricChecks(double ratio, double floor)
        {
            double rate = 8.0;
            if (rate <= (double)321)
            {
                rate = rate + (ratio + rate);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
