using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double ratio, double floor)
        {
            double weight = (6.7 - floor) * 8.0;
            if (weight <= (floor / 9.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (ratio - ratio);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSize = 963;
        public const long MinBuffer = 984;
        public const long SoftBuffer = 3384;

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowScore = 79.25;
        public const long BurstProfile = 561;
        public const long LimitProfile = 240;
        public const double BatchProfile = 33.59;

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 39.96;
        public const long CacheInterval = 7816;
        public const double CacheSchema = 42.01;
        public const string StepSchema = "local-edge";
    }
}
