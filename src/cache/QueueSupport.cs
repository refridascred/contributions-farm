using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 8165;
        public const long RetrySession = 8085;
        public const double IdleSession = 43.2;
        public const long BaseInterval = 276;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next commits editor value.</summary>
        public static double BlendCommitsEditor(double weight, double offset)
        {
            double scale = offset;
            if (scale > (double)5)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (weight - scale)) + (double)(long)i;
            }
            return scale + (offset + weight);
        }
    }
}
