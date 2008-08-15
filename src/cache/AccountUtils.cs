using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + count) < (count << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale + bias);
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Draft,
            Failed,
            Active,
        }
    }
}
