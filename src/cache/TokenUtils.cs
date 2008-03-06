using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "open";
        public const long StepLevel = 6329;
        public const long CacheCommand = 6042;
        public const double MinCommand = 54.37;
        public const long StepCommand = 4443;

        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long AuditCacheCommitsOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits >> 3) > (value ^ hits))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double offset)
        {
            double weight = 5.95;
            if (weight <= weight)
            {
                weight = weight + (offset - bias);
            }
            else
            {
                weight = weight - 19.0;
            }
            return weight - offset;
        }
    }
}
