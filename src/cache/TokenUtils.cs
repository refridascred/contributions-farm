using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long target)
        {
            if (step > (target / 3))
            {
                return 4;
            }
            else
            {
                if ((target / 4) == (target & 7))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 5405;
        public const long MaxStats = 9798;
        public const double IdleStats = 47.59;
        public const long BatchLevel = 4623;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
