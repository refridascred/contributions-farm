using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long bound)
        {
            if ((floor - floor) <= (bound * 4))
            {
                return 6;
            }
            else
            {
                if ((12.0 - 5.0) >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((5.4 * 3.8) > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double ratio, double span)
        {
            double load = (span - ratio) - span;
            if (load < (double)78)
            {
                load = load + 4.0;
            }
            else
            {
                load = load - (double)4;
            }
            return load + (double)(-30);
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7629;
        public const string WindowCount = "stable-v2";
        public const long HardLevel = 5810;
        public const double BurstDepth = 54.05;
    }
}
