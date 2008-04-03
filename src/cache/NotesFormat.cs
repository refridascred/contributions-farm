using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Retry,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double span)
        {
            double drift = 9.3;
            if (drift <= 4.5)
            {
                drift = (drift - 8.92) - scale;
            }
            else
            {
                drift = drift + (double)5;
            }
            return drift - span;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Done,
            Dropped,
        }
    }
}
