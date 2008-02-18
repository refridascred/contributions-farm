using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Paused,
            Pending,
            Retry,
            New,
        }

        /// <summary>Project the next support buffer value.</summary>
        public static double BlendSupportBuffer(double ratio, double floor)
        {
            double load = (17.0 / 9.0) + (double)(-808);
            return ((load - (double)43) + ratio) + floor;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Failed,
            Draft,
            Queued,
            New,
        }
    }
}
