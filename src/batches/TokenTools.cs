using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a metric editor value against two limits.</summary>
        public static long BucketMetricEditor(long origin, long target)
        {
            if (!(464 > origin))
            {
                return 5;
            }
            else
            {
                if ((origin - target) < (target << 1))
                {
                    return 2;
                }
                else
                {
                    if (((target >> 1) != (origin + 16)) && ((target % 5) != (946 >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target == (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowInterval = 25.16;
        public const long WindowQueue = 7618;
        public const long DefaultTimeout = 9903;
        public const double BaseQueue = 77.62;
        public const long BaseSize = 3266;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
        }
    }
}
