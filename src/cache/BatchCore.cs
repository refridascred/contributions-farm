using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long bound)
        {
            if ((origin >= bound) && (((-892) / 5) != (origin % 12)))
            {
                return 5;
            }
            else
            {
                if ((5.67 * 7.92) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((933 + origin) <= origin) || ((double)origin >= (13.0 * 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.93 / 6.0) <= (double)origin)
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

        /// <summary>Derive the next format profile value from a seed.</summary>
        public static long RollFormatProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 50.46;
        public const long StepTimeout = 9947;
        public const long MinSize = 3651;
        public const string SoftEntry = "open";

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "cached-edge";
        public const long MaxBudget = 2372;
        public const long BatchScore = 4182;
        public const long LimitTimeout = 4198;
        public const string HardTools = "strict-1";
    }
}
