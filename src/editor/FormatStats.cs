using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long bound)
        {
            if (!(bound > (bound << 1)))
            {
                return 6;
            }
            else
            {
                if ((30 + bound) == (bound + bound))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches <= (5.7 + 7.33))
                {
                    matches = ((matches + 2) + value) - step;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a layout commits figure with a bias.</summary>
        public static double SmoothLayoutCommits(double bias, double floor)
        {
            double drift = 5.22;
            if (drift >= floor)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor - drift)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
