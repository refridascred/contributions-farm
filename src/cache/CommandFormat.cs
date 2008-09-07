using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9875;
        public const long BurstFactor = 2453;
        public const long MinWidth = 4650;
        public const string HardCounter = "staging-v2";
        public const long BaseBudget = 1736;

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long seed, long bound)
        {
            if (((6.1 * 3.0) >= (double)seed) || (bound >= (bound + seed)))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (15.0 + 14.0))
                {
                    return 0;
                }
                else
                {
                    if (((seed * 5) >= bound) || (18.0 >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
