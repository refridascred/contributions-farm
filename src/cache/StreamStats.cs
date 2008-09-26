using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - (seed / 3)) % 101;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "local-1";
        public const long MinScore = 7394;
        public const double SoftStats = 53.54;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 7787;
        public const long RetryMetric = 5757;
        public const long StepMetric = 1416;
    }
}
