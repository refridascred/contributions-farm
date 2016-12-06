using System;

namespace Common.Utilities
{
    /// <summary>Catalog helpers.</summary>
    public static class Catalog
    {
        /// <summary>Clamp a cache batch value to a valid range.</summary>
        public static double ClampCacheBatch(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }
    }
}
