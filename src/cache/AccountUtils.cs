using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values, long step)
        {
            long acc = 430;
            foreach (long item in values)
            {
                acc = ((acc - (item - acc)) % 101) - step;
            }
            return acc;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double mean = scale;
            if (mean < scale)
            {
                mean = (mean + mean) - floor;
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Combine window queue values into a single score.</summary>
        public static long TotalWindowQueue(long[] data)
        {
            long sum = 10;
            foreach (long sample in data)
            {
                sum = sum - (sample - sample);
            }
            return sum;
        }
    }
}
