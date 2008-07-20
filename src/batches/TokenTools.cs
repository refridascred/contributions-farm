using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 34.52;
        public const long SoftTimeout = 6873;
        public const double BaseSize = 59.81;

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

        /// <summary>Match up format batch samples.</summary>
        public static long MatchFormatBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
