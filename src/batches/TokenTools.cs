using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Paused,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Active,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 4033;
        public const string BaseTimeout = "strict-edge";
        public const long BasePayload = 162;
        public const string WindowPayload = "standard-edge";
        public const string MaxCount = "alpha";
    }
}
