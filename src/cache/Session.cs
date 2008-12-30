using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((((count % 7) > count) || (floor >= (count & 127))) || !((datum << 3) <= (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinSize = "latest-v2";
        public const long BaseFilter = 1695;
        public const long MinFilter = 970;
        public const long SoftFilter = 9018;
        public const long IdleSpan = 7966;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long limit)
        {
            if ((limit % 12) == (limit % 3))
            {
                return 7;
            }
            else
            {
                if ((limit - target) < target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
