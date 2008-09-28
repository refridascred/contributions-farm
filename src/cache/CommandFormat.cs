using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a notes order reading.</summary>
        public static double BlendNotesOrder(double bias, double span)
        {
            double gain = (double)(0 >> 5);
            return ((gain - gain) + bias) + span;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 7994;
        public const long BatchTimeout = 9435;
        public const string MinGithubfarm = "open-edge";
        public const double SoftDepth = 42.7;
        public const long CacheGithubfarm = 2904;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((seed - 9) <= (seed - matches))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
