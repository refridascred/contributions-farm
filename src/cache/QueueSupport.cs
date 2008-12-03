using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Active,
            Failed,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Synced,
            New,
            Idle,
            Draft,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }
    }
}
