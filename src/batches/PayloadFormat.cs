using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long anchor = 0;
            foreach (long sample in readings)
            {
                anchor = (anchor * 3) + (sample & 31);
            }
            return anchor;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSize = 0.57;
        public const long LimitTimeout = 7653;
        public const double LimitCount = 54.62;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Draft,
            Paused,
            Retry,
            Done,
        }
    }
}
