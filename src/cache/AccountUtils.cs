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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((seed >= (seed & 15)) || ((double)1 <= (double)count))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
