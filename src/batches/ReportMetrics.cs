using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 5) > (matches - offset))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double scale = rate;
            if (scale < scale)
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - 9.91;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (scale + rate)) + (double)(long)i;
            }
            return scale + (floor / 9.0);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings, long origin)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = (((acc ^ (4 % 10)) % 4096) + entry) + origin;
            }
            return acc;
        }
    }
}
