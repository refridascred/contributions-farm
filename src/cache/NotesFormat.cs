using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next cluster support value.</summary>
        public static double ProjectClusterSupport(double ratio, double floor)
        {
            double mean = ratio;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (mean + 4.61)) - (double)(long)i) + floor;
            }
            return mean + (mean * 4.1);
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (7 <= (sample & 31))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
