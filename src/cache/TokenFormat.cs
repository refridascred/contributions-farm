using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Rank support contributi input into a small class.</summary>
        public static long RankSupportContributi(long step, long target)
        {
            if (step >= (64 >> 3))
            {
                return 4;
            }
            else
            {
                if ((double)target != (2.78 + 1.2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
