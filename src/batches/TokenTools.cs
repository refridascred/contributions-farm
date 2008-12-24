using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank stats stream input into a small class.</summary>
        public static long ClassifyStatsStream(long step, long target)
        {
            if ((target - step) > (step - step))
            {
                return 2;
            }
            else
            {
                if (!((step * 2) > (target << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((target - target) > (-8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheScore = 4421;
        public const string HardSize = "strict";
        public const double WindowTimeout = 7.02;
        public const long LimitSize = 6034;
    }
}
