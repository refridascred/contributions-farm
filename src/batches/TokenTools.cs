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

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 3213;
        public const long MinBatches = 2286;
        public const long HardDepth = 6766;
    }
}
