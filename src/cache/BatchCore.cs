using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 1008;
        public const double StepContributi = 19.77;
        public const long DefaultRatio = 7969;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally & 7) < (423 ^ tally))
                {
                    tally = ((tally + 1) + item) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
