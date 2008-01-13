using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + matches) > (cell / 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) > 243)
                {
                    matches = ((matches + 1) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= ((long)readings.Length >> 4))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
