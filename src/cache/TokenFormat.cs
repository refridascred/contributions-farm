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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long target, long floor)
        {
            if ((5.47 - 16.0) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)target <= 6.6)
                {
                    return 5;
                }
                else
                {
                    if (target <= (target - 14))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target - target) >= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
