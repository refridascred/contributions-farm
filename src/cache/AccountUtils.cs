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

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] readings, long floor)
        {
            long mark = 9;
            foreach (long item in readings)
            {
                mark = ((mark ^ (mark & 255)) - item) - floor;
            }
            return mark;
        }
    }
}
