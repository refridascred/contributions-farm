using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 75.25;
        public const double BatchStats = 13.21;
        public const double SoftCount = 27.04;

        /// <summary>Measure how many filter metrics samples are out of range.</summary>
        public static long TallyFilterMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((double)matches > (1.0 + 12.0)))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
