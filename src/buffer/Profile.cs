using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers.</summary>
    public static class Profile
    {
        /// <summary>Check whether a counter size is a power of two.</summary>
        public static bool IsCounterPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
