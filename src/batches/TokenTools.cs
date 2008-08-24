using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long bound)
        {
            if (((bound ^ bound) > floor) || ((14.0 - 3.0) >= (double)bound))
            {
                return 5;
            }
            else
            {
                if (floor >= (bound * 3))
                {
                    return 3;
                }
                else
                {
                    if (bound <= (bound / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor * 5) < bound) || ((double)floor == (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((8.49 - 7.2) >= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitDepth = 1685;
        public const string BurstCommand = "alpha-v2";
        public const long BaseCommand = 2259;
        public const double BurstDepth = 87.33;
        public const long LimitFactor = 2465;
    }
}
