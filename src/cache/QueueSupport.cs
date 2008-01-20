using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Draft,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double scale2 = scale;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 - scale) + (double)(long)i) + span;
            }
            return scale2 + (double)804;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches < (target + matches))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
