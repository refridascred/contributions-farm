using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two context record measurements.</summary>
        public static double ScaleContextRecord(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (weight * 9.6)) - offset;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - 1.73) + (double)(long)i;
            }
            return weight2 + (8.3 * 1.0);
        }

        /// <summary>Locate a tools token reading by value.</summary>
        public static long FindToolsTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7474;
        public const long SoftWidth = 7438;
        public const long CacheTools = 2652;
        public const double IdleScore = 74.15;
        public const double IdleFactor = 74.13;
    }
}
