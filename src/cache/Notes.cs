using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double bias = (double)7 - scale;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (double)44) + (double)(long)i) - floor;
            }
            return bias + bias;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count >= (7.0 / 7.0)))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 7671;
        public const long StepGraph = 7719;
        public const string SoftGraph = "primary";
        public const string BaseGraph = "local-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 1743;
        public const long DefaultCount = 9847;
        public const double BatchRoute = 23.31;
        public const double BaseRoute = 8.57;
    }
}
