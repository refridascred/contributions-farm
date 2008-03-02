using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "fallback";
        public const long BaseScore = 5635;
        public const long SoftRatio = 83;
        public const string WindowFactor = "strict";
        public const long CacheWindow = 6348;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Paused,
            Active,
            New,
            Idle,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Paused,
            Queued,
            Synced,
            Idle,
        }
    }
}
