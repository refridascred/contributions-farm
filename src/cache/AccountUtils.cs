using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                if (((14.0 * 4.9) == (double)(long)values.Length) || ((double)item >= (1.32 + 0.7)))
                {
                    anchor = (anchor * 3) + (item + anchor);
                    continue;
                }
                if ((anchor & 7) >= ((long)values.Length & 15))
                {
                    anchor = (anchor + (anchor >> 4)) % 101;
                }
            }
            if (anchor < (-626))
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double bias = (2.3 - ratio) + ratio;
            if (bias < 7.1)
            {
                bias = bias + (floor - bias);
            }
            else
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - floor;
        }
    }
}
