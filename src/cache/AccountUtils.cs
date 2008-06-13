using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double span)
        {
            double rate = (double)(1 << 1);
            return ((rate - (9.7 + rate)) + ratio) + span;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item == (18.0 + 9.9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "strict-v2";
        public const double HardBudget = 0.77;
        public const long BatchAlready = 7908;
        public const double CacheInterval = 14.32;
    }
}
