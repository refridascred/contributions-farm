using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double mean = floor - floor;
            return mean + (ratio / 8.0);
        }

        /// <summary>Roll a commits route counter forward.</summary>
        public static long RollCommitsRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstScore = "alpha-1";
        public const long CacheLevel = 7759;
        public const long MinChecks = 5729;
    }
}
