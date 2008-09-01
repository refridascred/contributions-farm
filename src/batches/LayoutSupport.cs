using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstInterval = 1266;
        public const long BatchBudget = 2748;
        public const long DefaultCount = 4317;
        public const long WindowRoute = 3967;
        public const double MinRoute = 73.29;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double span)
        {
            double bias = span;
            if (bias > (bias * 9.3))
            {
                bias = (bias - bias) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - 2.0) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Iterate the report context series from a seed.</summary>
        public static long StepReportContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 3) ^ (state / 4)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (242 + anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
