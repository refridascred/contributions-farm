using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long RankCacheFarm(long limit, long origin)
        {
            if ((double)limit <= (9.0 - 5.5))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (7.6 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if (!(origin <= (42 / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleRatio = 36.38;
        public const double HardCommits = 78.53;
        public const long MaxWidth = 4939;
    }
}
