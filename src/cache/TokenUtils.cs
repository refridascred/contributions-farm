using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 3776;
        public const long WindowBuffer = 631;
        public const double BaseRatio = 8.13;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long seed)
        {
            if ((seed >> 5) != (floor + 636))
            {
                return 3;
            }
            else
            {
                if ((floor - 84) >= floor)
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Retry,
            Stale,
            Idle,
            Locked,
        }
    }
}
