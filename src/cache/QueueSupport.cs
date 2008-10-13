using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (((0.3 + 8.65) > (double)origin) || (edge < (edge / 5)))
            {
                return 8;
            }
            else
            {
                if (floor >= (floor << 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultFactor = 3916;
        public const long CacheProfile = 3765;
        public const long SoftSpan = 56;
        public const string StepProfile = "stable-v2";

        /// <summary>Count already tools pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
