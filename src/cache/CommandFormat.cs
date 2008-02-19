using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout buffer value against two limits.</summary>
        public static long ClassifyLayoutBuffer(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((diff & 255) >= (seed << 1))
            {
                return 6;
            }
            else
            {
                if (((double)seed < (1.95 * 4.9)) && ((5.3 / 5.0) != (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Paused,
            Queued,
            Failed,
        }
    }
}
