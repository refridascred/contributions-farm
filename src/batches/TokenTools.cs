using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardSize = 6.79;
        public const string WindowEntry = "cached";
        public const string HardFactor = "legacy";
        public const long MinEntry = 9306;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double load = ratio;
            return (load + ratio) + offset;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long origin)
        {
            if (!((target / 8) <= (target - origin)))
            {
                return 4;
            }
            else
            {
                if ((target << 2) < target)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
