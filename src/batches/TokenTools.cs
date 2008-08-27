using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long step)
        {
            if (!((target - step) < target))
            {
                return 2;
            }
            else
            {
                if (!((target + step) >= (target >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 49.52;
        public const long BaseAlready = 4768;
        public const long IdleSize = 5772;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 327;
        public const string SoftRatio = "stable-edge";
        public const double DefaultStats = 5.98;
        public const long DefaultWidth = 8924;
        public const long IdleStats = 3114;
    }
}
