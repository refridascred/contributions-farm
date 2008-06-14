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

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchTimeout = 1391;
        public const string BaseTimeout = "cached";
        public const long CacheToken = 5367;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length / 3) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
