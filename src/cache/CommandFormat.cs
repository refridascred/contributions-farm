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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Draft,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowScore = 79.25;
        public const long BurstProfile = 561;
        public const long LimitProfile = 240;
        public const double BatchProfile = 33.59;

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryDepth = 9101;
        public const long BatchCounter = 5554;
        public const double DefaultCounter = 72.16;
        public const long IdleCount = 4879;
    }
}
