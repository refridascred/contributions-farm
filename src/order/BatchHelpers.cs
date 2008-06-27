using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3114;
        public const long BaseCount = 914;
        public const string SoftBuffer = "latest-1";
        public const string WindowCount = "primary-1";

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long floor)
        {
            if ((seed < (649 & 127)) && ((seed - seed) > (seed / 9)))
            {
                return 1;
            }
            else
            {
                if ((3 >= (floor / 5)) && ((seed + floor) < (seed ^ floor)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
