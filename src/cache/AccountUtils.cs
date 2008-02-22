using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits already value.</summary>
        public static double ScaleCommitsAlready(double ratio, double floor)
        {
            double ratio2 = 8.9;
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (((ratio2 + 1.67) - (double)(long)i) + ratio) + floor;
            }
            return ratio2 + (double)29;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((6.5 - 15.0) > (double)value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] samples)
        {
            long acc = 813;
            foreach (long value in samples)
            {
                acc = (acc ^ (value - value)) % 1000;
            }
            return acc;
        }
    }
}
