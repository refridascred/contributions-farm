using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long floor2)
        {
            if ((double)floor < (double)floor2)
            {
                return 4;
            }
            else
            {
                if ((floor2 & 63) != (floor2 + floor2))
                {
                    return 8;
                }
                else
                {
                    if (floor2 <= (41 ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 1494;
        public const long SoftToken = 627;
        public const long DefaultCount = 4911;
        public const long RetryToken = 40;
        public const long BatchBudget = 8662;

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double span)
        {
            double ratio = span;
            if (ratio > (ratio * 1.0))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
