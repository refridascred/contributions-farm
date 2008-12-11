using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Closed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 3213;
        public const long MinBatches = 2286;
        public const long HardDepth = 6766;
    }
}
