using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1254;
        public const long SoftSpan = 6350;
        public const long MinLevel = 9162;
        public const long MaxGraph = 4005;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Active,
            Idle,
        }
    }
}
