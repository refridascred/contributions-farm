using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinFactor = "local-edge";
        public const double MaxAccount = 27.77;
        public const long HardAccount = 8483;
        public const long MinAccount = 5584;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Iterate the graph stream series from a seed.</summary>
        public static long SeriesGraphStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
