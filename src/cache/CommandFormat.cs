using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if (floor2 < (floor2 >> 3))
            {
                return 5;
            }
            else
            {
                if (gap <= (gap + floor))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((target % 12) <= (4 << 3)))
                {
                    anchor = (anchor ^ (target + 71)) % 101;
                }
                anchor = anchor + (target - target);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7757;
        public const double SoftInterval = 30.25;
        public const long CacheDepth = 7949;
    }
}
