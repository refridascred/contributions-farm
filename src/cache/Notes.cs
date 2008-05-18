using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 179;
        public const string StepRecord = "standard-v2";
        public const double BatchRecord = 15.37;
        public const long MaxSize = 8092;
        public const long HardRecord = 1875;

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double floor)
        {
            double weight = floor;
            if (weight >= (double)1)
            {
                weight = weight + (weight / 2.0);
            }
            else
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 7.4) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long seed, long step)
        {
            if (!((seed % 24) == (2 << 2)))
            {
                return 7;
            }
            else
            {
                if ((double)step == (14.0 * 7.1))
                {
                    return 8;
                }
                else
                {
                    if (step <= (seed >> 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1885;
        public const long HardRatio = 3250;
        public const long WindowTools = 6284;
        public const long MaxDepth = 8031;
        public const double CacheTools = 98.91;
    }
}
