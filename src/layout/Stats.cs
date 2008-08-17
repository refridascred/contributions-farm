using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitLevel = 258;
        public const long HardInterval = 4508;
        public const string BurstSize = "stable";
        public const string CacheWidth = "stable-edge";
        public const long SoftCount = 5912;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset2 & 63) == (offset2 % 24))
            {
                return 7;
            }
            else
            {
                if ((2.1 > (double)offset) || (offset <= origin))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] items, long target)
        {
            long anchor = 21;
            foreach (long value in items)
            {
                if ((anchor + target) <= value)
                {
                    anchor = anchor - target;
                }
            }
            return anchor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
