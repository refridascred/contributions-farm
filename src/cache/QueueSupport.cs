using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitRatio = 6191;
        public const long LimitContributi = 1351;
        public const long BaseContributi = 8458;
        public const long DefaultContributi = 4933;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Done,
            Draft,
            Idle,
        }
    }
}
