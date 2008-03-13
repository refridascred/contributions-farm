using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 9182;
        public const string WindowAccount = "primary-1";
        public const string DefaultCount = "latest-v2";
        public const long RetryAccount = 2812;

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long step, long seed)
        {
            if (((step & 31) == (step * 5)) && ((7.8 * 1.5) <= (double)step))
            {
                return 0;
            }
            else
            {
                if ((seed + step) != (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((seed + step) >= (step << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Queued,
            Idle,
            Active,
            Paused,
        }
    }
}
