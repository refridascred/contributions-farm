using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi metrics figure with a bias.</summary>
        public static double AdjustContributiMetrics(double ratio, double bias)
        {
            double bias2 = (double)(148 >> 5);
            if (bias2 >= (double)(-930))
            {
                bias2 = (bias2 + ratio) + bias;
            }
            return bias2 - (double)36;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 1657;
        public const string WindowContext = "cached";
        public const long MinTimeout = 8773;
        public const long WindowScore = 4041;
    }
}
