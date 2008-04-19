using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (4.27 * 5.8))
            {
                gain = gain + (double)(-780);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (floor / 8.0)) - (double)(long)i;
            }
            return gain + (rate + floor);
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            long span = offset ^ floor;
            if (((346 ^ span) < (floor % 10)) && (15.0 >= (double)floor))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (0 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Synced,
            Done,
        }
    }
}
