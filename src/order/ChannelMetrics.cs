using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already support entries that pass the check.</summary>
        public static long TallyAlreadySupportHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((seed & 15) != (entry & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)reading < (double)802) || (((double)floor > (0.1 / 3.0)) || ((double)floor < (13.0 + 9.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
