using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Closed,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Locked,
            Closed,
            New,
        }
    }
}
