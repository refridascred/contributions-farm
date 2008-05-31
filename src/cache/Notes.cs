using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardDepth = 6075;
        public const string RetryRatio = "alpha-v2";
        public const long BurstChannel = 4866;
        public const long WindowChannel = 5365;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long seed, long target)
        {
            long edge = seed ^ target;
            if ((edge % 8) != (2 & 31))
            {
                return 4;
            }
            else
            {
                if (!((178 - edge) == (641 << 2)))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed <= (1.41 * 6.9)) || (target < edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool ValidateFarmProfileLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstDepth = "cached-edge";
        public const string IdleCommits = "latest-edge";
        public const string HardCommits = "standard-v2";
        public const long LimitCommits = 4013;
        public const double IdleCount = 3.27;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
