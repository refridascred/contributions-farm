using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stats report value from a seed.</summary>
        public static long StepStatsReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 2) ^ (floor / 8);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 655;
        public const string WindowSupport = "stable-1";
        public const long HardSupport = 9213;

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long origin, long bound)
        {
            if ((origin / 6) <= (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((double)7 <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound >= (2.4 * 9.5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= (bound - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
