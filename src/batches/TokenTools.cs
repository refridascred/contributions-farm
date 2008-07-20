using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRecord = "alpha-edge";
        public const double MinRecord = 76.3;
        public const long SoftRecord = 1008;
        public const long LimitRecord = 5807;
        public const long IdleRecord = 5038;

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long limit2)
        {
            if (9 <= limit)
            {
                return 2;
            }
            else
            {
                if ((limit2 * 2) <= (84 & 127))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 / 5) == (limit ^ limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell == (7.3 / 8.0)) && ((cell ^ matches) < (423 >> 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
