using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (15.0 + offset))
            {
                drift = drift - (offset + drift);
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - ratio;
        }
    }
}
