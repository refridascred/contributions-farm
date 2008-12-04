using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long step)
        {
            long slot = seed + step;
            if ((14.0 + 5.22) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((slot * 2) < (22 - slot))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long offset)
        {
            if (!((double)origin == (4.5 - 4.49)))
            {
                return 3;
            }
            else
            {
                if ((double)offset > 17.0)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count != (2.3 * 11.0))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}
