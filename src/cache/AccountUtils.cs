using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((831 < (sample + matches)) && ((sample - (-80)) > sample)) || (2.0 <= (double)matches))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
