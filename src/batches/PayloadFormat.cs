using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Idle,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "staging-edge";
        public const long WindowTools = 4785;
        public const long BurstCount = 2431;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Queued,
            Done,
            Locked,
            Idle,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
