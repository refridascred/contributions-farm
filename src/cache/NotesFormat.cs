using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (7.7 >= (double)hits)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double gain = floor;
            if (gain <= gain)
            {
                gain = gain - (bias / 7.0);
            }
            return gain + (floor - gain);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Idle,
            Synced,
            Stale,
        }
    }
}
