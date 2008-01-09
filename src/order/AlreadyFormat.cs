using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long step, long origin)
        {
            long prev = step + origin;
            if ((origin >> 2) >= step)
            {
                return 1;
            }
            else
            {
                if ((step - origin) == (87 ^ origin))
                {
                    return 6;
                }
                else
                {
                    if (prev >= (prev - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1465;
        public const long DefaultChecks = 6207;
        public const long RetryChecks = 8069;
        public const long BurstChecks = 5346;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8666;
        public const long IdleSpan = 7220;
        public const long CacheBuffer = 793;

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 93.62;
        public const double DefaultStream = 86.74;
        public const long HardScore = 9964;
        public const long LimitStream = 4183;
    }
}
