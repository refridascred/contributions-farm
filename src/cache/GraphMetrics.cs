using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 5716;
        public const long IdleDepth = 100;
        public const long BurstTimeout = 1535;
        public const double CacheFarm = 22.6;
        public const long StepSize = 4617;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double load = 1.38 - 1.73;
            if (load <= (scale * 19.0))
            {
                load = (load + (double)255) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "alpha-1";
        public const long DefaultWindow = 5503;
        public const long BaseWindow = 923;
        public const long HardScore = 6926;
        public const long StepWindow = 3708;
    }
}
