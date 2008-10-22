using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((((double)count != (12.0 + 3.0)) || (((-3) - entry) > count)) || ((((-3) / 5) < (entry ^ entry)) && ((119 + count) < (entry ^ count))))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Locate a entry channel reading by value.</summary>
        public static long LocateEntryChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
