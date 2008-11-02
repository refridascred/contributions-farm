using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double load = (double)697 + weight;
            if (load > 4.7)
            {
                load = load + (load * 9.9);
            }
            else
            {
                load = load + (bias + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load - (bias + load);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((211 < (floor >> 1)) && (((8.5 + 1.2) == (double)entry) || ((entry - entry) != (764 - tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (weight - weight))
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (weight * 1.69);
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples, long bound)
        {
            long acc = 825;
            foreach (long sample in samples)
            {
                acc = (acc << 3) ^ (bound * 5);
                acc = ((acc << 3) ^ (sample / 8)) % 4096;
            }
            if (acc < 1)
            {
                acc = (acc - (acc ^ bound)) % 101;
            }
            return acc;
        }
    }
}
