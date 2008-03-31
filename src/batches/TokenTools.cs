using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 5929;
        public const double BurstWidth = 86.34;
        public const double MinBudget = 78.66;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long step, long offset)
        {
            long step2 = step - offset;
            if ((8.6 * 3.0) != (double)offset)
            {
                return 5;
            }
            else
            {
                if (step2 > offset)
                {
                    return 0;
                }
                else
                {
                    if ((step + offset) != (197 - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5 + step2) <= step) && ((step2 + offset) >= 72))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2482;
        public const long IdleBudget = 4570;
        public const long DefaultCache = 1987;
    }
}
