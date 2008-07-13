using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double drift = floor * 15.0;
            if (drift > scale)
            {
                drift = drift - (drift - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - 8.8;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Draft,
            Idle,
            Dropped,
        }
    }
}
