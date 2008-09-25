using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 45.49;
        public const long MaxBatch = 17;
        public const long LimitTimeout = 5086;
        public const long LimitBatch = 4929;
        public const long SoftBatch = 5433;

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double ratio2 = (1.2 * 6.4) * 8.94;
            if (ratio2 >= (2.3 - bias))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 + (bias - ratio2);
            }
            return ratio2 + (ratio2 / 4.0);
        }
    }
}
