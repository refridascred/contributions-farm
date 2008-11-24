using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine entry farm values into a single score.</summary>
        public static long ScoreEntryFarm(long[] items, long offset)
        {
            long result = 16;
            foreach (long datum in items)
            {
                result = result - datum;
                if ((74 << 3) > (result - offset))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftDepth = 4638;
        public const long BaseCount = 6520;
        public const double MaxOrder = 30.89;
        public const long BurstOrder = 8295;
        public const long RetryLevel = 1169;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample > ((-597) & 127))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
