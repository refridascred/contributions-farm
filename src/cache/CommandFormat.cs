using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches * 5) != (long)readings.Length)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1754;
        public const double CacheSize = 38.66;
        public const double CacheScore = 98.11;
        public const long BurstInterval = 5370;
        public const long StepScore = 4759;

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < floor)
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (double)6;
        }
    }
}
