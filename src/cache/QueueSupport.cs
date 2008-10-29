using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxCount = "local-1";
        public const long BurstAccount = 8331;
        public const double IdleAccount = 16.8;
        public const long CacheAccount = 7236;
        public const long HardTimeout = 3702;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            if (((target + seed) <= target) || ((seed / 8) > (seed / 7)))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (1.0 + 5.6))
                {
                    return 0;
                }
                else
                {
                    if ((seed - target) >= (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
