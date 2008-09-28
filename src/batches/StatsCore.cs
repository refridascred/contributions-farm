using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a command filter reading.</summary>
        public static double SmoothCommandFilter(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 < (scale - scale2))
            {
                scale2 = scale2 - floor;
            }
            return scale2 + floor;
        }

        /// <summary>Measure how many schema contributi samples are out of range.</summary>
        public static long CountSchemaContributiHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (6.0 + 9.2))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 8899;
        public const long WindowMetrics = 3279;
        public const long IdleMetrics = 2963;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric window readings against a bound.</summary>
        public static bool ValidateMetricWindowBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit session already readings against a rule.</summary>
        public static long AuditSessionAlreadyOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - 33) == (bound - bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
