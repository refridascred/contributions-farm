using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long offset)
        {
            if (((double)bound == (double)1) || ((offset << 3) < (-20)))
            {
                return 7;
            }
            else
            {
                if (offset <= (7 << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 1411;
        public const long SoftChannel = 4867;
        public const double HardChannel = 33.72;
        public const double IdleChannel = 49.35;
        public const double MaxDepth = 18.72;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
