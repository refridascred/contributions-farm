using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "stable-1";
        public const long HardTools = 4825;
        public const long HardSpan = 6166;
        public const double BaseCount = 59.6;
        public const long MinTools = 2191;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxScore = 42.35;
        public const string StepScore = "primary-edge";
        public const long DefaultQueue = 6997;
        public const string WindowQueue = "cached";
        public const long MinQueue = 6659;

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if ((double)origin > (11.0 * 1.77))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) > (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if (origin < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
