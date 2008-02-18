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

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double bias)
        {
            double scale = bias;
            if (scale <= (double)41)
            {
                scale = scale - (scale - scale);
            }
            else
            {
                scale = scale - (rate / 8.0);
            }
            return scale + (double)481;
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
