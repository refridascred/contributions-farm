using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "open";
        public const double BaseBudget = 19.86;
        public const double IdleFactor = 65.53;
        public const long MaxBatch = 1700;
        public const long IdleLevel = 8493;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long step)
        {
            if (((step >> 5) > step) || ((step * 5) == (seed & 15)))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (6.0 - 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((84 / 4) <= (seed / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 2) < (96 + seed))
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
        }
    }
}
