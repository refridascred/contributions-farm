using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4297;
        public const long CacheInterval = 8731;
        public const long MaxScore = 8349;
        public const double DefaultSize = 77.28;
        public const long MinWindow = 8618;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)entry == (7.0 * 3.0)) || ((478 % 12) < (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double ratio = floor;
            return (ratio + floor) + scale;
        }
    }
}
