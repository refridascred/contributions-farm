using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Project the next format layout value.</summary>
        public static double SmoothFormatLayout(double gain, double floor)
        {
            double gain2 = floor / 9.0;
            if (gain2 > (double)0)
            {
                gain2 = gain2 - (gain * 0.83);
            }
            return gain2 + (gain * 3.95);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings, long offset)
        {
            long anchor = 578;
            foreach (long value in readings)
            {
                anchor = (((anchor - 844) % 255) - value) - offset;
            }
            if (anchor > 7)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }
    }
}
