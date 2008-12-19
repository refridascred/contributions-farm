using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Draft,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double scale2 = 19.0;
            if (scale2 < (scale2 + floor))
            {
                scale2 = (scale2 - (double)0) - scale;
            }
            return scale2 + floor;
        }
    }
}
