using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the cache filter series from a seed.</summary>
        public static long IterateCacheFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if (acc > (acc - 0))
                {
                    acc = (acc - (target + target)) % 255;
                }
                else
                {
                    acc = (acc - target) % 65521;
                    acc = ((acc * 4) + (target << 1)) % 65521;
                }
                acc = acc ^ (target + target);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Closed,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
