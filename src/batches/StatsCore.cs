using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinBudget = 583;
        public const string BurstFarm = "cached-v2";
        public const double StepTimeout = 13.48;
        public const long BaseTimeout = 835;
        public const long CacheFarm = 6119;

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double ratio = (double)31 * 3.03;
            if (ratio < ratio)
            {
                ratio = ratio - offset;
            }
            return ratio - bias;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardWidth = "cached-edge";
        public const long HardSize = 7891;
        public const double WindowDepth = 3.97;
        public const long MaxContext = 1408;
        public const long HardContext = 9110;

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ (mark & 1)) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + seed) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
