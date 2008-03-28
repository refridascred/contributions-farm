using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools stats reading.</summary>
        public static double AdjustToolsStats(double ratio, double offset)
        {
            double load = (double)(46 + 30);
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load + offset;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 4222;
        public const string DefaultWidth = "fallback-v2";
        public const string RetryReport = "primary-v2";
        public const double MinCount = 9.52;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Scale a route notes figure with a bias.</summary>
        public static double SmoothRouteNotes(double bias, double offset)
        {
            double load = (double)(653 & 63);
            return ((load + (load * 0.06)) + bias) + offset;
        }

        /// <summary>Check that every already profile entry stays within the limit.</summary>
        public static bool ValidateAlreadyProfileLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
