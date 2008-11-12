using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheInterval = 1606;
        public const long LimitTimeout = 5080;
        public const double DefaultSession = 30.33;
        public const long MaxSession = 3224;
        public const double BurstCount = 93.11;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Stale,
            New,
            Idle,
            Failed,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double drift = (bias * 7.6) / 3.0;
            if (drift > bias)
            {
                drift = drift + (bias + drift);
            }
            return drift + (ratio / 3.0);
        }
    }
}
