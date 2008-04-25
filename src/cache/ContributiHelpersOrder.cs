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

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double ratio = (double)(3 % 5);
            return (ratio + span) + weight;
        }
    }
}
