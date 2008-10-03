using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every queue report entry stays within the limit.</summary>
        public static bool GuardQueueReportBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi batch measurements.</summary>
        public static double ProjectContributiBatch(double weight, double offset)
        {
            double mean = 8.0;
            if (mean < offset)
            {
                mean = mean + (double)(-447);
            }
            else
            {
                mean = mean - (mean - weight);
            }
            return mean + weight;
        }
    }
}
