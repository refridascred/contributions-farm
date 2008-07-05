using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultTimeout = 8.17;
        public const long BaseBudget = 75;
        public const long HardCluster = 104;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a checks format figure with a bias.</summary>
        public static double ScaleChecksFormat(double weight, double span)
        {
            double load = span;
            for (int i = 0; i < 4; i++)
            {
                load = (load + weight) - (double)(long)i;
            }
            return load + (span + weight);
        }
    }
}
