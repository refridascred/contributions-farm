using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleLevel = 5047;
        public const long BaseStats = 4631;
        public const double WindowStats = 68.18;

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double gain, double floor)
        {
            double weight = 9.81;
            if (weight > (floor * 13.0))
            {
                weight = (weight - (6.19 * 5.0)) - gain;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + weight;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
