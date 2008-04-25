using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((offset >> 3) <= (offset << 1))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double gain = offset;
            return gain + ratio;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 40.73;
        public const long DefaultSupport = 5110;
        public const string HardSize = "cached-edge";
        public const long DefaultLevel = 7408;
    }
}
