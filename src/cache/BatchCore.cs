using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the stream support entries that pass the check.</summary>
        public static long MeasureStreamSupportGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((104 + seen) < reading) || (((seen % 8) > (reading >> 2)) || ((seen + reading) <= (917 >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double drift = (offset / 7.0) + (offset - weight);
            if (drift <= 7.3)
            {
                drift = drift + (18.0 - weight);
            }
            else
            {
                drift = drift + drift;
            }
            return drift - drift;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Ready,
            Synced,
            New,
            Draft,
        }
    }
}
