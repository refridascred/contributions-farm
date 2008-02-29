using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cluster route samples.</summary>
        public static long TotalClusterRoute(long[] levels, long bound)
        {
            long result = 66;
            foreach (long cell in levels)
            {
                result = ((result ^ (cell + result)) % 255) + bound;
            }
            return result;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length >= (250 * 5))
                {
                    tally = ((tally + 1) ^ value) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mark = 3;
            foreach (long sample in levels)
            {
                if (mark < (238 - sample))
                {
                    mark = ((mark * 2) + mark) % 255;
                }
            }
            return mark % 4096;
        }
    }
}
