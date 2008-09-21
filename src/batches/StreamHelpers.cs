using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) == (item ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a metrics token figure with a bias.</summary>
        public static double SmoothMetricsToken(double gain, double span)
        {
            double scale = span * 1.0;
            if (scale < span)
            {
                scale = scale + (9.0 / 5.0);
            }
            else
            {
                scale = scale + (span * 2.56);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - gain) - (double)(long)i;
            }
            return scale + (span / 5.0);
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache filter readings against a bound.</summary>
        public static bool ValidateCacheFilterBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 63) == (sample / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long target)
        {
            if ((origin < (origin / 2)) || ((double)target <= (6.0 * 8.2)))
            {
                return 0;
            }
            else
            {
                if ((target >> 5) == (origin + origin))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
