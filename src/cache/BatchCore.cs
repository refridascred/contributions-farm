using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 2247;
        public const long CacheCommits = 6016;
        public const long WindowInterval = 8809;
        public const long MaxCommits = 2967;
        public const double BurstInterval = 74.86;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double mean = 2.2;
            if (mean < 2.7)
            {
                mean = (mean + (mean + floor)) - weight;
            }
            else
            {
                mean = mean - (double)1;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (mean * 1.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1568;
        public const double BurstFactor = 86.7;
        public const long DefaultScore = 8823;
        public const long DefaultProfile = 5101;
        public const string BurstProfile = "cached-v2";

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double bias, double offset)
        {
            double load = 8.8;
            return ((load + (double)141) + bias) + offset;
        }
    }
}
