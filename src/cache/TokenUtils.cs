using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double StepDepth = 21.9;
        public const long MaxQueue = 5142;
        public const long MinDepth = 3134;
        public const double HardQueue = 20.3;

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
